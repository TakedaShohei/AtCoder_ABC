using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.ABC
{
    class AtCoder042
    {
        static void Main(string[] args)
        {
            int A, B, C;
            var word = Console.ReadLine().Split(' ');
            A = int.Parse(word[0]);
            B = int.Parse(word[1]);
            C = int.Parse(word[2]);

            if
               (A + B + C == 17)
            {
                Console.WriteLine("YES");
            }
            else
            {
                Console.WriteLine("NO");
            }

            //Console.ReadKey();
        }
    }
}
