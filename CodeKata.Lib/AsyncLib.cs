using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CodeKataLib
{
    public class AsyncLib
    {
        public static async Task<int> SumAsync(int value1, int value2)
        {
            return await Task.Run(() => value1 + value2);
        }
    }
}
