using System;
using System.Configuration;

namespace Lab_2
{
    public static class Configuration
    {
        public static long GetR0 => Int64.Parse(GetValue("r0"));
        public static long GetA => Int64.Parse(GetValue("a"));
        public static long GetM => Int64.Parse(GetValue("m"));
        public static long GetAmount => Int64.Parse(GetValue("amountOfValues"));
        public static long GetAmountOfSequences => Int64.Parse(GetValue("amountOfSequences"));

        private static string GetValue(string name)
        {            
            return ConfigurationManager.AppSettings[name];
        }
    }
}
