using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("First 10 Natural Numbers:");
            for (int i = 1; i <= 10; i++)
            {
                Console.Write(i + " ");
            }

            Console.WriteLine("\n\nFirst 10 even ");
            int evenCounter = 1;
            int evenNumber = 2;
            while (evenCounter <= 10)
            {
                Console.Write(evenNumber + " ");
                evenNumber += 2;
                evenCounter++;
            }

            Console.WriteLine("\n\nFirst 10 Odd Natural Numbers:");
            int oddCounter = 1;
            int oddNumber = 1;
            do
            {
                Console.Write(oddNumber + " ");
                oddNumber += 2;
                oddCounter++;
            } while (oddCounter <= 10);

            Console.ReadLine();
        }
    }
}
