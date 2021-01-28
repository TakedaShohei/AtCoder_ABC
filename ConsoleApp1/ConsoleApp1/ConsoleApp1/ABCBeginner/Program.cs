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

            // https://atcoder.jp/contests/practice2/tasks/practice2_j
            var line = Console.ReadLine().Split(' ');
            var N = int.Parse(line[0]);
            var Q = int.Parse(line[1]);
            var seg = new Segtree<long, Op>(Console.ReadLine().Split(' ').Select(long.Parse).ToArray());

            for (int q = 0; q < Q; q++)
            {
                line = Console.ReadLine().Split(' ');
                int t = int.Parse(line[0]);
                int l = int.Parse(line[1]) - 1;
                int r = int.Parse(line[2]);
                switch (t)
                {
                    case 1:
                        seg[l] = r;
                        break;
                    case 2:
                        Console.WriteLine(seg.Prod(l, r));
                        break;
                    case 3:
                        Console.WriteLine(1 + seg.MaxRight(l, num => num < r));
                        break;
                }
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
