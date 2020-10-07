using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace CodeKata.Core
{
    public static class ParallelLib
    {
        public static int SumParallely(int number1, int number2)
        {
            int sum;
            Parallel.Invoke(new Action[] { new Action(() => { sum = number1 + number2; }) });
            return sum;
        }
    }
}
