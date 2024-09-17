namespace FelsökningInlämning4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* Case 1 --- klar
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

            /* Case 2 --- klar
            for (int i = 1; i < 100; i++) // ändra till i <= 100
            {
                Console.WriteLine(i);
            }
            */

            /*
             * Case 3 --- klar
            for (int i = 1; i <= 5; i++) // saknarr ++ ingen ökning 
            {
                for (int j = 1; j <= i; j++) // saknarr ++ ingen ökning 
                {
                    Console.Write(j + " ");
                }
                Console.WriteLine();
            }
            */

            /* Case 4 --- klar
            int i = 1;
            while (i <= 5)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write(""); // är tom, lägg till "" så funkar det.
                }

                Console.WriteLine(); // skriver ut en tom rad
                i++;
            }
            */

            /* 
             * Case 5 --- klar
            int i = 1;

            switch (i)
            {
                case 1:// saknar "break;"
                case 2:
                    Console.WriteLine("Two");
                    break;
                default:
                    Console.WriteLine("Other");
                    break;
            }
            */
           
            /* Case 6 --- klar
            int i = 10;

            if (i = 5) // måste ha == för att verifiera 
            {
                Console.WriteLine("i är 5");
            }
            */


        }
    }
}
