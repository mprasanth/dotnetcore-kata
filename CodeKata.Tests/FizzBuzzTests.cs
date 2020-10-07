using System;
using Xunit;

namespace XUnitTestProject1
{
    public class FizzBuzzTests
    {
        [Fact]
        public void Prints100Numbers()
        {
            FizzBuzz fizzBuzz = new FizzBuzz();
            var result = fizzBuzz.PrintNumbers();
            Assert.Equal(100, result.Count);
        }
        [Fact]  
        public void PrintsFizzForMultiplesOf3()
        {
            FizzBuzz fizzBuzz = new FizzBuzz();
            var result = fizzBuzz.PrintNumbers();
            Assert.Equal("Fizz", result[2]);
        }
        [Fact]
        public void PrintsBuzzForMultiplesOf5()
        {
            VerifyTest("Buzz", 4);
        }

        private static void VerifyTest(string expectedValue, int ordinal)
        {
            FizzBuzz fizzBuzz = new FizzBuzz();
            var result = fizzBuzz.PrintNumbers();
            Assert.Equal(expectedValue, result[ordinal]);
        }

        [Fact]
        public void PrintsFizzBuzzForMultiplesOf3And5()
        {
            VerifyTest("FizzBuzz", 14);
        }
    }
}
