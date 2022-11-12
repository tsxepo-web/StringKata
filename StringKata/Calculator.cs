using System;
using System.Collections.Generic;
using System.Linq;

namespace StringKata
{
    public class Calculator
    {
       public static int Add(string numbers)
       {
            if (numbers == "")
            { return 0; }

            var integerNumber = Convert.ToInt32(numbers);
            return integerNumber;

       }
       
    }
}