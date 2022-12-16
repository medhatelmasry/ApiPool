using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ApiPool.Models.Utils;

public static class StringExtension
{
    public static string ToFriendlyCase(this string PascalString)
    {
        var str = PascalString;
        str = PascalString.First().ToString().ToUpper() + str.Substring(1);
        return Regex.Replace(str, "(?!^)([A-Z])", " $1");
    }
}