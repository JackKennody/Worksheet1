namespace Queastion_1
{/// <summary>
/// Name : Jack Kennedy
/// Date : 25 - 1 - 2023
/// a)	Write a method called PrintIntegersFor which uses a for loop to print
/// all the integers between 40 and 60 in ascending order to the console.
/// b)	Write a second method called PrintIntegersWhile which does the same thing using a while loop.
/// c)	Write a third method, PrintIntegersDo, which does the same thing using a do..while loop.
/// d)	Write a method, PrintExcludingFor, which uses a  for loop to print all integers between 40 and 60 excluding 46 and 48.
/// e)	Write a method, PrintDescendingFor, which uses a for loop to print all integers between 60 and 40 in descending order.
/// </summary>
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Part a");
            PrintIntegersFor();

            Console.WriteLine("\nPart b");
            PrintIntegersWhile();

            Console.WriteLine("\nPart c");
            PrintIntegersDo();

            Console.WriteLine("\nPart d");
            PrintExcludingFor();

            Console.WriteLine("\nPart e");
            PrintDescendingFor();
        }

        static void PrintIntegersFor() // part a
        {
            for (int i = 40; i <= 60; i++)
            {
                Console.WriteLine(i);
            }
        }

        static void PrintIntegersWhile() // part b
        {
            int i = 40;

            while (i <= 60)
            {
                Console.WriteLine(i);
                i++;
            }
        }

        static void PrintIntegersDo() // part c
        {
            int i = 40;

            do
            {
                Console.WriteLine(i);
                i++;
            }
            while (i <= 60);
        }

        static void PrintExcludingFor() // part d
        {
            for (int i = 40; i <= 60; i++)
            {
                if (i == 46 || i == 48)
                {
                   
                }
                else
                {
                    Console.WriteLine(i);
                }

            }
        }

        static void PrintDescendingFor()
        {
            for (int i = 60; i >= 40; i--)
            {
                Console.WriteLine(i);
            }
        }
    }
}