using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kata.Tests
{
    [TestFixture]
    public  class HydrationTests
    {
        [Test]
        [TestCase(2,ExpectedResult =1)]
        [TestCase(0, ExpectedResult = 0)]
        [TestCase(0.82, ExpectedResult = 0)]
        [TestCase(6.7, ExpectedResult = 3)]
        [TestCase(1787, ExpectedResult = 893)]
        [TestCase(11.8, ExpectedResult = 5)]
        public static int Find_Required_Water_For_Time(double time)
        {
           return Kata.Console.Hydation.Litres(time);
        }
    }
}
