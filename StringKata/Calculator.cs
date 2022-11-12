using System;
using System.Collections.Generic;
using System.Linq;

namespace StringKata
{
    public class Calculator
    {
       public static int Add(string numbers)
       {    
            var separators = new char[] { ',', '\n' };

            var integerNumber = numbers
                .Split(Delimiters, StringSplitOptions.RemoveEmptyEntries)
;               .Select(int.Parse);

            return integerNumber.Sum();
       }
       
    }
}