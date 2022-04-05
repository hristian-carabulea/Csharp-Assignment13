using System;
/// <summary>
/// Create a method that returns an array of multiples of a given number
/// </summary>
namespace Assignment13
{
    internal class Program
    {
        public static double[] ArrayOfMultiples(double number, int arrayLength)
        {
            double[] arrayOfDoubles = new double[arrayLength];

            for (int i = 0; i < arrayLength; i++)
            {
                arrayOfDoubles[i] = Convert.ToDouble(number * (i + 1));
            }

            return arrayOfDoubles;
        }


        static void Main()
        {
            //get the required input from the user
            Console.Write("Enter number to be multiplied: ");
            double num = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter how many times the number should be multiplied: ");
            int arrayLen = Convert.ToInt32(Console.ReadLine());

            //pass the entered data to the method ArrayOfMultiples, and get back the full array
            double[] arrayOfDoubles = ArrayOfMultiples(num, arrayLen);

            // write out the contents of the array
            Console.Write("[");
            for (int i = 0; i < arrayLen; i++)
            {
                arrayOfDoubles[i] = Convert.ToDouble(num * (i + 1));
                if (i < arrayLen - 1)
                {
                    Console.Write(arrayOfDoubles[i] + ", ");
                }
                else Console.Write(arrayOfDoubles[i]);

            }
            Console.WriteLine("]");

            //let the user end the console by entering any key
            Console.Write("Enter any key to end program.");
            Console.ReadKey();
        }
    }
}

