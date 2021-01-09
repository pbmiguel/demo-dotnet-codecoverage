using System;
using NumbersDemo;
using Xunit;

namespace NumbersTests
{
    public class UnitTest1
    {
        [Theory, InlineData(-1), InlineData(0), InlineData(1)]
        public void IsPrime_ValuesLessThan2_ReturnFalse(int value) =>
            Assert.False(Prime.IsIt(value), $"{value} should not be prime");
    }
}