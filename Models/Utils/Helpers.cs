using System;
using System.Collections.Generic;
using System.IO;
using ApiPool.Controllers.Toons;
using ApiPool.Models.Restaurants;
using ApiPool.Models.Toons;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;

namespace ApiPool.Models.Utils
{
    public class Helpers
    {
        public static string AdjustPictureUrl(HttpRequest request, string pictureUrl)
        {
            string scheme = request.Scheme;
            string siteUrl = request.Host.Value.ToString();

            return $"{scheme}://{siteUrl}/" + pictureUrl;
        }

        void SomeMethod<T>(List<T> someList)
        {
            if (typeof(T) == typeof(Toon))
            {
                // etc     
            }
        }


        public static List<T>? AdjustPictureUrlInList<T>(HttpRequest request, List<T> list)
        {
            if (typeof(T) == typeof(Toon))
            {
                List<Toon>? adjustedToons = list! as List<Toon>;

                foreach (var t in adjustedToons!)
                {
                    if (!string.IsNullOrEmpty(t.PictureUrl))
                    {
                        t.PictureUrl = AdjustPictureUrl(request, t.PictureUrl);
                    }
                }
                return adjustedToons as List<T>;

            }
            else if (typeof(T) == typeof(Restaurant))
            {
                List<Restaurant>? adjustedToons = list as List<Restaurant>;

                foreach (var t in adjustedToons!)
                {
                    if (!string.IsNullOrEmpty(t.LogoUrl))
                    {
                        t.LogoUrl = AdjustPictureUrl(request, t.LogoUrl);
                    }
                }
                return adjustedToons as List<T>;
            }
            else if (typeof(T) == typeof(Menu))
            {
                List<Menu>? adjustedList = list as List<Menu>;

                foreach (var t in adjustedList!)
                {
                    if (!string.IsNullOrEmpty(t.PictureUrl))
                    {
                        t.PictureUrl = AdjustPictureUrl(request, t.PictureUrl);
                    }
                }
                return adjustedList as List<T>;
            }
            return new List<T>();
        }

/*
        public static List<Picture> GetPictures(ILogger<PicturesController> logger,IWebHostEnvironment env, HttpRequest request)
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
                name = name.Replace(flintstonePath, "");
                
                //logger.LogWarning($"scheme {scheme}");
                logger.LogWarning($"siteUrl {siteUrl}");
                logger.LogWarning($"fileName {fileName}");
                
                var url = $"{scheme}://{siteUrl}/images/flintstone/{fileName}";
                logger.LogWarning($"url {url}");

                pictures.Add(new Picture
                {
                    Name = name.ToFriendlyCase(),
                    Url = url
                });
                
            }

            foreach (var item in disneyImages)
            {
                string fileName = item.Substring(item.LastIndexOf(Path.DirectorySeparatorChar) + 1);
                string name = fileName.Substring(0, fileName.LastIndexOf(@"."));
                name = name.Replace(disneyPath, "");
                pictures.Add(new Picture
                {
                    Name = name.ToFriendlyCase(),
                    Url = $"{scheme}://{siteUrl}/images/disney/{fileName}"
                });
            }

            return pictures;
        }
*/
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
                name = name.Replace(flintstonePath, "");
                pictures.Add(new Picture
                {
                    Name = name.ToFriendlyCase(),
                    Url = $"{scheme}://{siteUrl}/images/flintstone/{fileName}"
                });
            }

            foreach (var item in disneyImages)
            {
                string fileName = item.Substring(item.LastIndexOf(Path.DirectorySeparatorChar) + 1);
                string name = fileName.Substring(0, fileName.LastIndexOf(@"."));
                name = name.Replace(disneyPath, "");
                pictures.Add(new Picture
                {
                    Name = name.ToFriendlyCase(),
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

        public static string GetHostUrl(HttpRequest request)
        {
            var host = string.Format("{0}://{1}", request.Scheme, request.Host);
            return host;
        }
    }

}
