using System;
using AtCoder;
using System.Runtime.CompilerServices;
using System.Linq;

namespace ConsoleApp1
{
    class Program
    {
        static void Main()
        {
            SourceExpander.Expander.Expand();
            

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
        }
    }
    struct Op : ISegtreeOperator<long>
    {
        public long Identity => default;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public long Operate(long x, long y)
        {
            return default;
        }
    }


}
