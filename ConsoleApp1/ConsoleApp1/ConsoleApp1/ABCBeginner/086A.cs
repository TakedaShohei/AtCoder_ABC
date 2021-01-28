using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.ABCBeginner
{
    class _086A
    {
        private static void Select(string[] args)
        {
            int A, B, C;
            var word = System.Console.ReadLine().Split(' ');
            A = int.Parse(word[0]);
            B = int.Parse(word[1]);
            C = int.Parse(word[2]);

            if
               (A + B + C == 17)
            {
                System.Console.WriteLine("YES");
            }
            else
            {
                System.Console.WriteLine("NO");
            }

            //Console.ReadKey();
        }
    }
}
