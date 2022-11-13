using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kata.Console
{
    public class Sheeps
    {
        public Sheeps()
        {

        }
        public static int CountSheeps(bool[] sheeps)
        {
            //TODO
            int quantity = 0;

            //foreach (bool element in sheeps)
            //{
            //    if (element)
            //    {
            //        quantity++;
            //    }
            //}

            quantity = sheeps.Count(c => c);
            return quantity;
        }
    }

    public static class Clock
    {
        public static int Past(int h, int m, int s)
        {
            //Clock shows h hours, m minutes and s seconds after midnight.
            //Your task is to write a function which returns the time since midnight in milliseconds.

            //#Happy Coding! ^_^
            return (int)(new TimeSpan(h, m, s)).TotalMilliseconds;

        }
    }

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
    }

    public static class Hydation
    {
        public static int Litres(double time)
        {
            //The fun begins here.
            var result = Math.Floor(0.5 * time);
            return (int)result;
        }
    }

    public static class StringHandler
    {
        public static string DoubleChar(string s)
        {
            // your code here
            //Given a string, you have to
            //return a string in which each character(case-sensitive) is repeated once.
            //Examples(Input->Output):

            //*"String"-> "SSttrriinngg"
            //* "Hello World"-> "HHeelllloo  WWoorrlldd"
            //* "1234!_ "-> "11223344!!__  "

            //var result = "";
            //for (int counter = 0; counter < s.Length; counter++)
            //{
            //    result += s[counter].ToString() + s[counter].ToString();
            //}

            //return result;
            return String.Join("", s.Select(x=> "" + x +x));
            
        }
    }

}
