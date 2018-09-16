using System;

namespace Lab_2.Exceptions
{
    public class NotEnoughParamsException : Exception
    {
        public NotEnoughParamsException()
            : base()
        {            
        }

        public NotEnoughParamsException(string distributionName)
            : base($"Not enough parameters for {distributionName} distribution.")
        {            
        }
    }
}
