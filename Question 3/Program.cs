namespace Question_3
{/// <summary>
/// Name : Jack Kennedy
/// Date : 27 - 1 - 2023
/// a)	 Write a method called PrintTriangle, to print the below pattern to the console.
/// Printing one ‘#’ at a time.
/// b)	Write another method called PrintTriangleUpsideDown to print the same pattern
/// upside down.
/// c)	Write another method PrintTriangleGeneral which takes an integer as a parameter
/// and prints the pattern with the number of rows which was input. If you call the method
/// with the argument 5 you should get the pattern from a) above.
/// d)	Write another method PrintTriangleGeneralCharacter which takes an integer and a
/// character as parameters and prints the pattern with the number of rows of the
/// entered character which was input. If you call the method with the arguments,
/// 5, ‘#’ you should get the pattern from a) above.
/// </summary>
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Part a");
            PrintTriangle();

            Console.WriteLine("\nPart b");
            PrintTriangleUpsideDown();

            Console.WriteLine("\nPart c");
            //PrintTriangleGeneral();

            Console.WriteLine("\nPart d");
            //PrintTriangle();
        }
        static void PrintTriangle() // part a
        {
            string hashtag = "#";
            int i = 0;
            while (5 >= i)
            {
                int counter = 0;
                while (counter < i)
                {
                    Console.Write(hashtag);
                    counter++;
                }
                Console.Write($"\n");
                i++;
            }

        }

        static void PrintTriangleUpsideDown() // part c
        {
            string hashtag = "#";
            int i = 5;
            while (0 <= i)
            {
                int counter = 0;
                while (counter < i)
                {
                    Console.Write(hashtag);
                    counter++;
                }
                Console.Write($"\n");
                i--;
            }
        }

        static void PrintTriangleGeneral()
        {
            string hashtag = "#";
            int x = 0;

            //user input
            Console.Write($"{"Enter a number of rows for your triangle", -40} : ");
            int i = int.Parse(Console.ReadLine());

            while (i >= x)
            {
                int counter = 0;
                while (counter < x)
                {
                    Console.Write(hashtag);
                    counter++;
                }
                Console.Write($"\n");
                x++;
            }
        }
    }
}