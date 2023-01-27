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
            int oddnumbers = CountOddNumbers();
            Console.WriteLine($"You entered in {oddnumbers} odd numbers");

            Console.WriteLine("\nPart b");
            AverageMinMax();
        }

        static int CountOddNumbers() // part a
        {
            //declare variables
            int[] numbers = new int[5];
            int i = 0, oddnumbers = 1;

            for (i = 0; i < numbers.Length; i++)
            {
                Console.Write($"{"Enter a number", -20} : ");
                numbers[i] = int.Parse(Console.ReadLine());
            }

            for (i = 0; i < numbers.Length; i++)
            {
                if ((numbers[i] % 2) != 0)
                {
                    oddnumbers = oddnumbers + 1;
                }
            }

            return oddnumbers;
        }
        static void AverageMinMax() // part b
        {
            // declare variables
            int[] numbers = new int[5];

            for (int i = 0; i < numbers.Length; i++)
            {
                Console.Write($"{"Enter a number", -20} : ");
                numbers[i] = int.Parse(Console.ReadLine());
                
            }

            //find smallest number
            int smallestNumber=numbers[0];
            for (int i = 0; i < numbers.Length; i++)
            {
                if (smallestNumber > numbers[i])
                    smallestNumber = numbers[i];
            }


            Console.WriteLine($"The smallest number you entered was {smallestNumber}");

            //find largest number
            int biggestNumber = numbers[0];
            for (int i = 0; i < numbers.Length; i++)
            {
                if (biggestNumber < numbers[i])
                    biggestNumber = numbers[i];
            }
            Console.WriteLine($"The largest number you entered was {biggestNumber}");

            //find average
            int average = 0, total = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                total = total + numbers[i];
            }
            average = total / numbers.Length;
            Console.WriteLine($"The average of the numbers you entered was {average}");
        }
    }
}