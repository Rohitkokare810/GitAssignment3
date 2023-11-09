using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("First 10 Fibonacci Numbers:");

            int n = 10;
            int firstNumber = 0, secondNumber = 1;

            for (int i = 0; i < n; i++)
            {
                Console.Write(firstNumber + " ");

                int nextNumber = firstNumber + secondNumber;
                firstNumber = secondNumber;
                secondNumber = nextNumber;
            }

            Console.ReadLine();
        }
    }
}
