// Edgar Skönnegård SUT24
//
// Skapade en loop för enklare koll om casen funkar.
//
namespace FelsökningInlämning4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool exitProgram = false;
            while (!exitProgram)
            {
                Console.WriteLine("Vilket fall vill du testa?");
                Console.WriteLine("1" +
                    "2" +
                    "3" +
                    "4" +
                    "5" +
                    "6" +
                    "7: Exit program");
                int choice = 0;
                try
                {
                    choice = Convert.ToInt32(Console.ReadLine());
                }
                catch
                {
                    Console.WriteLine("invalid input");
                }
                switch (choice)
                {
                    case 1:
                        int number = 2;

                        if (number > 3)
                        {
                            // Saknade semikolon.
                            Console.WriteLine("Talet är större än tre");
                        }
                        // saknade mellanslag i else if, (elseif).
                        else if (number < 3)
                        {
                            Console.WriteLine("Talet är mindre än tre");
                        }
                        break;
                    case 2:
                        // Ändrade till i <= 100.
                        for (int i = 1; i <= 100; i++)
                        {
                            Console.WriteLine(i);
                        }
                        break;
                    case 3:
                        // saknade ++ efter i, ingen ökning.
                        for (int i = 1; i <= 5; i++)
                        {
                            // saknade ++ efter j, ingen ökning.
                            for (int j = 1; j <= i; j++)
                            {
                                Console.Write(j + " ");
                            }
                            Console.WriteLine();
                        }
                        break;
                    case 4:
                        // Koden har inget output eftersom båda metoderna saknade argument.
                        int i = 1;
                        while (i <= 5)
                        {
                            for (int j = 1; j <= i; j++)
                            {
                                // Console.Write kräver ett argument annars blir det kompileringsfel. La till "*".
                                Console.Write("*");
                            }
                            // La till "*" så att den inte skriver en tom rad.
                            Console.WriteLine("*");
                            i++;
                        }
                        break;
                    case 5:
                        int i = 1;

                        switch (i)
                        {
                            case 1:
                                // Saknades "break;"
                                break;
                            case 2:
                                Console.WriteLine("Two");
                                break;
                            default:
                                Console.WriteLine("Other");
                                break;
                        }
                        break;
                    case 6:
                        int i = 10;
                        // Saknades == för att verifiera, hade enbart '='. 
                        if (i == 5)
                        {
                            Console.WriteLine("i är 5");
                        }
                        break;
                    case 7:
                        exitProgram = true;
                        break;
                    default:
                        break;
                }

            }
           

        }
    }
}
