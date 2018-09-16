using System;
using System.Collections.Generic;

namespace Lab_2.Utils
{
    public class Randomizer
    {
        private static readonly List<long> ListOfSimpleNumbers = new List<long>
        {
            99607, 99611, 99623, 99643, 99661, 99667,
            99679, 99689, 99707, 99709, 99713, 99719,
            99721, 99733, 99761, 99767, 99787, 99793,
            99809, 99817, 99823, 99829, 99833, 99839,
            99859, 99871, 99877, 99881, 99901, 99907,
            99923, 99929, 99961, 99971, 99989, 99991
        };

        public static long[] GetThreeRandomValuesFromList()
        {
            var result = new long[3];
            var random = new Random();
            var indexesOfValues = new List<int>();
            for (int i = 0; i < 3; i++)
            {
                var index = (int) ((random.Next(0, 36) * DateTime.Now.Millisecond) % 36);
                indexesOfValues.Add(index);
            }
            indexesOfValues.Sort();
            result[0] = ListOfSimpleNumbers[indexesOfValues[0]];
            result[1] = ListOfSimpleNumbers[indexesOfValues[1]];
            result[2] = ListOfSimpleNumbers[indexesOfValues[2]];
            return result;
        }
    }
}
