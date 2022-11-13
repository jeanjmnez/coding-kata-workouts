namespace Kata.Console
{
    public static class Hydation
    {
        public static int Litres(double time)
        {
            //The fun begins here.
            var result = Math.Floor(0.5 * time);
            return (int)result;
        }
    }

}
