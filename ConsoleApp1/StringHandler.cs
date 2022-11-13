using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kata.Console
{

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
