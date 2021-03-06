﻿using System.Text.RegularExpressions;

namespace EmpleoDotNet.Helpers
{
    public static class PrettyUrlHelper
    {
        /// <summary>
        /// Sanitiza un URL
        /// </summary>
        /// <remarks>http://stackoverflow.com/questions/6716832/sanitizing-string-to-url-safe-format</remarks>
        public static string SanitizeUrl(this string strToSanitize)
        {
            return strToSanitize == null 
                ? null 
                : Regex.Replace(strToSanitize, @"[^A-Za-z0-9_~]+", "-");
        }
    }
}