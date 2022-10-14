using System;
using System.Collections.Generic;
using System.IO;
using ApiPool.Models.Toons;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;

namespace ApiPool.Models.Utils
{
    public class Helpers
    {
        public static List<Picture> GetPictures(IWebHostEnvironment env, HttpRequest request)
        {
            string disneyPath = env.WebRootPath + $"{Path.DirectorySeparatorChar}images{Path.DirectorySeparatorChar}disney{Path.DirectorySeparatorChar}";
            string flintstonePath = env.WebRootPath + $"{Path.DirectorySeparatorChar}images{Path.DirectorySeparatorChar}flintstone{Path.DirectorySeparatorChar}";

            string[] disneyImages = Directory.GetFiles(disneyPath);
            string[] flintstoneImages = Directory.GetFiles(flintstonePath);

            List<Picture> pictures = new List<Picture>();

            string siteUrl = request.Host.Value.ToString();
            var scheme = request.Scheme;

            foreach (var item in flintstoneImages)
            {
                string fileName = item.Substring(item.LastIndexOf(Path.DirectorySeparatorChar) + 1);
                string name = fileName.Substring(0, fileName.LastIndexOf(@"."));
                pictures.Add(new Picture
                {
                    Name = name,
                    Url = $"{scheme}://{siteUrl}/images/flintstone/{fileName}"
                });
            }

            foreach (var item in disneyImages)
            {
                string fileName = item.Substring(item.LastIndexOf(@"\") + 1);
                string name = fileName.Substring(0, fileName.LastIndexOf(@"."));
                pictures.Add(new Picture
                {
                    Name = name,
                    Url = $"{scheme}://{siteUrl}/images/disney/{fileName}"
                });
            }

            return pictures;
        }

        public static bool IsPictureInLegitToonList(string pictureUrl, IWebHostEnvironment env, HttpRequest request)
        {
            var pictures = Helpers.GetPictures(env, request);
            bool isOk = false;
            foreach (var p in pictures)
            {
                //if (p.Url.Trim() == pictureUrl.Trim())
                if (string.Equals(p.Url!.Trim(), pictureUrl.Trim(), StringComparison.OrdinalIgnoreCase))
                {
                    isOk = true;
                    break;
                }
            }

            return isOk;
        }

        public static string GetFileNameFromUrl(string url)
        {
            Uri uri;
            if (!Uri.TryCreate(url, UriKind.Absolute, out uri!))
                uri = new Uri(url);

            return Path.GetFileName(uri.LocalPath);
        }

        public static string GetHostUrl(HttpRequest request) {
            var host = string.Format("{0}://{1}", request.Scheme, request.Host);
            return host;
        }
    }

}
