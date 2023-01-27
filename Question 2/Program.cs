namespace Question_2
{/// <summary>
/// Name : Jack Kennedy
/// Date : 27 - 1 - 2023
/// a)	Write a method, CountOddNumbers, which reads in 5 integer values from the console,
/// and returns the number of them which are odd. 
/// b)	Write a method, AverageMinMax, to read in 5 integer values from the console and
/// output their average, the smallest number entered and the largest number entered to the
/// console.
/// </summary>
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Part a");
            CountOddNumbers();
        }

        static void CountOddNumbers() // part a
        {
            //declare variables
            int[] numbers = new int[5];
            int i = 0, oddnumbers = 0;

            for (i = 0; i < numbers.Length; i++)
            {
                Console.Write($"{"Enter a number", -20} : ");
                numbers[i] = int.Parse(Console.ReadLine());
            }

            for (i = 0; i < numbers.Length; i++)
            {
                if ((numbers[i] % 2) == 0)
                {
                    oddnumbers = oddnumbers + 1;
                }
            }

            Console.WriteLine($"You entered in {oddnumbers} odd numbers");
        }
    }
}