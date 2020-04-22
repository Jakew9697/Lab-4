using System;

namespace Lab_4
{
    class Program
    {
        static void Main(string[] args)
        {
            int i;

            bool runAgain = true;

            while (true)
            {

                Console.WriteLine("Enter an integer: ");
                int total = int.Parse(Console.ReadLine());
                {

                    for (i = 1; i <= total; i++)

                    {
                        Console.WriteLine(i * i);
                    }

                    for (i = 1; i <= total; i++)

                    {
                        Console.WriteLine(i * i * i);
                    }
                    Console.WriteLine("would you like to continue? y/n? ");
                    string yn = Console.ReadLine();
                    if (yn == "y")
                    {
                        runAgain = true;
                    }                   
                    else
                    {
                        break;
                    }
                }
            }
        }

    }
}
