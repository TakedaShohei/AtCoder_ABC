using System;

using System.Linq;
namespace ConsoleApp1.ABCBeginner
{
    class example
    {
        private static void Test(string[] args)
        {
            int a, b;
            
            var input_ = Console.ReadLine().Split(' ');
            a = int.Parse(input_[0]);
            b = int.Parse(input_[1]);

            
            if ((a*b)%2 == 0)
            {
                System.Console.WriteLine("Even");
            }
            else
            {
                System.Console.WriteLine("Odd");
            }

        }
    }
}
