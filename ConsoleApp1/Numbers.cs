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
    }

}
