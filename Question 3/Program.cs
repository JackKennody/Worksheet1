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
        }
        static void PrintTriangle()
        {
            string hashtag = "#";
            int i = 0;
            while (5 >= i)
            {
                int counter = 0;
                while (counter > i)
                {
                    Console.WriteLine(hashtag);
                    counter++;
                }
                i++;
            }
            
        }
    }
}