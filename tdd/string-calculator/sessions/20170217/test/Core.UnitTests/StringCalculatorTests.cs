﻿using Xunit;

namespace GusztavVargadDr.Katas.Tdd.UnitTests
{
    public class StringCalculatorTests
    {
        public class Add : StringCalculatorTests
        {
            // ReSharper disable once UnusedParameter.Local
            private static void AssertResultEquals(string numbers, int expectedResult)
            {
                var stringCalculator = new StringCalculator();

                var actualResult = stringCalculator.Add(numbers);

                Assert.Equal(expectedResult, actualResult);
            }

            public class EmptyString : Add
            {
                [Fact]
                public void ReturnsZero()
                {
                    AssertResultEquals(string.Empty, 0);
                }
            }

            public class OneNumber : Add
            {
                [Theory]
                [InlineData("0", 0)]
                [InlineData("1", 1)]
                [InlineData("2", 2)]
                public void ReturnsNumber(string numbers, int number)
                {
                    AssertResultEquals(numbers, number);
                }
            }
        }
    }
}