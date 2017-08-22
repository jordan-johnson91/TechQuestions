using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TechQuestions
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a number");
            int userNumber = int.Parse(Console.ReadLine());

            if(userNumber % 3 == 0 && userNumber % 5 == 0)
            {
                Console.WriteLine("FizzBuzz");
            }
            else if(userNumber % 3 == 0)
            {
                Console.WriteLine("Fizz");
            }

            else if(userNumber % 5 == 0)
            {
                Console.WriteLine("Buzz");
            }
            else
            {
                Console.WriteLine("This number is not divisible by 3 or 5" );
            }
        }
    }
}
