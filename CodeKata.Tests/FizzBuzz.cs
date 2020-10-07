using System;
using System.Collections.Generic;

namespace XUnitTestProject1
{
    internal class FizzBuzz
    {
        internal List<string> PrintNumbers()
        {
            List<string> numbers = new List<string>();
            for(int  i = 1; i<101; i++)
            {
                if (i % 15 == 0)
                    numbers.Add("FizzBuzz");
                else if (i % 3 ==0)
                    numbers.Add("Fizz");
                else if (i%5 == 0)
                        numbers.Add("Buzz");
                else
                numbers.Add(i.ToString());
            }
                
            return numbers;
        }
    }
}