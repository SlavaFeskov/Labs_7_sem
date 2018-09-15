using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Configuration;

namespace Lab_2
{
    public class Generator
    {
        public static List<double> GenerateValues(Int64 x0, Int64 amount, Int64 a, Int64 m)
        {
            Int64 currentX = x0;
            List<double> result = new List<double>();            

            for (int i = 0; i < amount; i++)
            {
                currentX = GenerateXnFromXnMinusOne(currentX, a, m);
                result.Add((double)currentX / m);
            }

            return result;
        }

        public static Int64 GenerateXnFromXnMinusOne(Int64 xnMinusOne, Int64 a, Int64 m)
        {
            return (a * xnMinusOne) % m;
        }        
    }
}
