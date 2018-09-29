using System;
using System.Linq;

namespace Bank_System.Utils
{
    public static class StringExtension
    {
        public static bool GetBoolean(this string str)
        {
            return !str.Equals("0");
        }

        public static string MakeBoolean(this string str)
        {
            return str.ToLower().Equals("true") ? "1" : "0";
        }

        public static string MakeDataBaseConventionColumnName(this string str)
        {
            var subStr = str.Substring(1);
            return str[0] + string.Join("", subStr.Select(c => char.IsUpper(c) ? "_" + c : "" + c));            
        }
    }
}