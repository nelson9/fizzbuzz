using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NUnit.Framework;
using Assert = Microsoft.VisualStudio.TestTools.UnitTesting.Assert;

namespace PortrTest.UnitTests
{
    [TestFixture]
    public class FizzBuzzTest
    {

        [Test]
        public void StartGame()
        {
            var fizzBuzz = new FizzBuzz(3,5,1,20,3);
            var actual = fizzBuzz.StartGame();

            Assert.AreEqual("1 2 lucky 4 buzz fizz 7 8 fizz buzz 11 fizz lucky 14 fizzbuzz 16 17 fizz 19 buzz fizz: 4 buzz: 3 fizzbuzz: 1 lucky: 2 integer: 10", actual);
        }
    }
}
