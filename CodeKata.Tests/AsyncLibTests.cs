using CodeKataLib;
using System;
using Xunit;

namespace KataTests
{
    public class AsyncLibTests
    {
        [Fact]
        public void AsyncMethodReturnsSumAsynchronously()
        {
            int value1 = 10, value2 = 30;
            Assert.Equal(40, AsyncLib.SumAsync(value1, value2).Result);
        }

        [Fact]
        public void AsyncMethodAwaits()
        {
            int value1 = 22, value2 = 33;
            Assert.Equal(55, AsyncLib.SumAsync(value1, value2).Result);
        }
    }
} 
