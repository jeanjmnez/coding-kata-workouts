using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kata.Tests
{
    public class StringHandlerTests
    {
        [TestFixture]
        public class Test
        {
            [Test]
            [TestCase("abcd", ExpectedResult = "aabbccdd")]
            [TestCase("Adidas", ExpectedResult = "AAddiiddaass")]
            [TestCase("1337", ExpectedResult = "11333377")]
            [TestCase("illuminati", ExpectedResult = "iilllluummiinnaattii")]
            [TestCase("123456", ExpectedResult = "112233445566")]
            [TestCase("%^&*(", ExpectedResult = "%%^^&&**((")]
            public static string FixedTest(string s)
            {
                return Kata.Console.StringHandler.DoubleChar(s);
            }
        }
    }
}
