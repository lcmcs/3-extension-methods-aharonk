using System;
using ExtensionMethods;
using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ExtensionsTest
{
    [TestClass]
    public class IntegerExtensionsTest
    {
        [TestMethod]
        public void SefirahTest()
        {
            // This does not require extensive testing because it's copied from an already extensively-tested library
            1.EnglishSefira().Should().Be("Today is one day of the Omer.");
        }

        [TestMethod]
        public void FactorialTest()
        {
            0.Factorial().Should().Be(1);
            1.Factorial().Should().Be(1);
            5.Factorial().Should().Be(120);
            12.Factorial().Should().Be(479001600); // highest int factorial
        }

        [TestMethod]
        public void LongFactorialTest()
        {
            15.Factorial().Should().Be(1307674368000);
        }

        [TestMethod]
        public void FactorialErrorTest()
        {
            this.Invoking(_ => (-1).Factorial()).Should()
                .Throw<NotImplementedException>()
                .WithMessage("Cannot currently compute factorial of a negative number.");
        }

        [TestMethod]
        public void SummationTestBase()
        {
            0.Summation().Should().Be(0);

            1.Summation().Should().Be(1);
            2.Summation().Should().Be(3);
            100.Summation().Should().Be(5050);

            (-1).Summation().Should().Be(-1);
            (-2).Summation().Should().Be(-3);
            (-100).Summation().Should().Be(-5050);
        }

        [TestMethod]
        public void SummationTestFormula()
        {
            1.Summation().Should().Be(1);
            2.Summation().Should().Be(3);
            100.Summation().Should().Be(5050);
        }

        [TestMethod]
        public void SummationTestNegative()
        {
            (-1).Summation().Should().Be(-1);
            (-2).Summation().Should().Be(-3);
            (-100).Summation().Should().Be(-5050);
        }
    }
}