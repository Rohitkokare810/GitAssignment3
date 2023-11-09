using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[5];

            // Populating the array with random integer values
            Random random = new Random();
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = random.Next(1, 101); // Generating random integers between 1 and 100
            }

            // Displaying the array elements
            Console.WriteLine("Array Elements:");
            foreach (int num in array)
            {
                Console.Write(num + " ");
            }

            // Calculating the sum of array elements
            int sum = 0;
            foreach (int num in array)
            {
                sum += num;
            }

            // Calculating the average of array elements
            double average = (double)sum / array.Length;

            // Displaying the sum and average
            Console.WriteLine("\n\nSum of Array Elements: " + sum);
            Console.WriteLine("Average of Array Elements: " + average);

            Console.ReadLine();
        }
    }
}
