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

}
