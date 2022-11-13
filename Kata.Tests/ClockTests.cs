using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kata.Tests
{
    [TestFixture]
    public class ClockTests
    {
        [Test]
        public void Convert_Time_To_MilliSeconds()
        {
            Assert.That(Console.Clock.Past(0,1,1), Is.EqualTo(61000));
        }
    }
}
