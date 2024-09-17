namespace FelsökningInlämning4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* Case 1
             *
            int number = 2;

            if (number > 3)
            {
                Console.WriteLine("Talet är större än tre") // saknar semikolon.
            }
            elseif(number < 3) // inget mellanslag i else if
            {
                Console.WriteLine("Talet är mindre än tre");
            }
            */

            /* Case 2
            for (int i = 1; i < 100; i++) // ändra till i <= 100
            {
                Console.WriteLine(i);
            }
            */

            for (int i = 1; i <= 5; i)
            {
                for (int j = 1; j <= i; j)
                {
                    Console.Write(j + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
