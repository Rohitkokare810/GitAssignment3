using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int score;
            Console.WriteLine("enter score");
            score = int.Parse(Console.ReadLine());

            if(score>=90)
            {
                Console.WriteLine("grade : A");
            }
            else if (score >= 80)
            {
                Console.WriteLine("grade : B");
            }
            else if (score >= 70)
            {
                Console.WriteLine("grade : C");
            }
            else if (score >= 60)
            {
                Console.WriteLine("grade : D");
            }
            else if (score <= 59)
            {
                Console.WriteLine("grade : F");
            }
            Console.ReadKey();
        }
    }
}
