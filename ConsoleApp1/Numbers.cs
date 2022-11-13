using System.Xml.Linq;
using System;

namespace Kata.Console
{
    public static class Numbers
    {
        public static int PositiveSum(int[] arr)
        {
            var sumresult = 0;


            //foreach (var number in arr)
            //{
            //    if (number > 0)
            //    {
            //        sumresult = sumresult + number;
            //    }
            //}

            sumresult = arr.Where(n => n > 0).Sum();
            return sumresult;
        }

        public static int Opposite(int number) => -number;

        public static bool CheckItemExists(object[] a, object value)
        {

            var arr = a.ToList();
            return arr.Contains(value);
        }

        public static int Sum(int[] numbers)
        {
            //Task

            //Sum all the numbers of a given array(cq.list),
            //except the highest and the lowest element(by value, not by index!).

            //The highest or lowest element respectively is
            //a single element at each edge, even if there are more than one with the same value.

            //Mind the input validation.
            //Example

            //{ 6, 2, 1, 8, 10 } => 16
            //{ 1, 1, 11, 2, 3 } => 6

            var result = 0;
            if ((numbers?.Length > 0))
            {
                if (numbers.Length != numbers.Distinct().Count())
                {
                     return numbers.Distinct().Sum();
                }else
                {
                    var numberList = numbers?.Distinct().ToList();

                    return numberList
                          .Where(d => d != numberList?.Max()
                                                 && d != numberList?.Min())
                          .Distinct()
                          .Sum();
                }
               
            }

            return result;

        }

    }

}
