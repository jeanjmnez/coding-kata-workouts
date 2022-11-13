using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kata.Tests
{
    [TestFixture]
    public class NumbersTests
    {
        [Test]        
        [TestCase(1, ExpectedResult = -1)]
        public static int Opposite_From_Number_Single_Result(int number)
        {
            return Kata.Console.Numbers.Opposite(number);
        }

        [Test]
        public static void Find_Number_Single_Result()
        {
            Assert.IsTrue(Kata.Console.Numbers.CheckItemExists(new object[] { 66, 101 }, 66));
            Assert.IsTrue(Console.Numbers.CheckItemExists(new object[] { 66, 101 }, 66));
            Assert.IsTrue(Console.Numbers.CheckItemExists(new object[] { 80, 117, 115, 104, 45, 85, 112, 115 }, 45));

            Assert.IsTrue(Kata.Console.Numbers.CheckItemExists(new object[] { 't', 'e', 's', 't' }, 'e'));
            Assert.IsFalse( Kata.Console.Numbers.CheckItemExists(new object[] { "what", "a", "great", "kata" }, "kat"));
        }
   

        [Test]
        [TestCase(new int[] { 1, 2, 3, 4, 5 }, ExpectedResult = 15)]
        [TestCase(new int[] { 1, -2, 3, 4, 5 }, ExpectedResult = 13)]
        [TestCase(new int[] { -1, 2, 3, 4, -5 }, ExpectedResult = 9)]
        [TestCase(new int[] { }, ExpectedResult = 0)]
        [TestCase(new int[] { -1, -2, -3, -4, -5 }, ExpectedResult = 0)]
        public static int Positive_Sum_Single_Result(int[] arr)
        {
            return Kata.Console.Numbers.PositiveSum(arr);
        }

        [Test]
        public void Sum_All_Items_Except_Highest_and_Lowest()
        {
            Assert.That(Kata.Console.Numbers.Sum(new[] { 6, 2, 1, 8, 10 }), Is.EqualTo(16));
            Assert.That(Kata.Console.Numbers.Sum(new[] { 6, 2, 1, 8, 10,10 }), Is.EqualTo(27));
            Assert.That(Kata.Console.Numbers.Sum(new[] { 6, 0, 1, 10,10 }), Is.EqualTo(17));
            Assert.That(Kata.Console.Numbers.Sum(null), Is.EqualTo(0));
        }
    }
}
