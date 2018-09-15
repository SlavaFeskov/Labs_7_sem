using System;
using System.Configuration;

namespace Lab_2
{
    public class Configuration
    {
        public long GetR0 => Int64.Parse(GetValue("r0"));
        public long GetA => Int64.Parse(GetValue("a"));
        public long GetM => Int64.Parse(GetValue("m"));

        public string GetValue(string name)
        {            
            return ConfigurationManager.AppSettings[name];
        }
    }
}
