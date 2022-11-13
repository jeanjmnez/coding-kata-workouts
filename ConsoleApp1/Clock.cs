namespace Kata.Console
{
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

}
