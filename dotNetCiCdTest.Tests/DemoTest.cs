using System;
using Xunit;

namespace dotNetCiCdTest.Tests
{
    public class UnitTest1
    {
        [Fact]
        public void TestPrintMessage()
        {
            string actual = Demo.SendMessage();
            string expected = "Hello";
            Assert.Equal(expected, actual);
        }
    }
}
