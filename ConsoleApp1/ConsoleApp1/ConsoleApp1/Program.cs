using System;
using AtCoder;
using System.Runtime.CompilerServices;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            SourceExpander.Expander.Expand();
            var seg = new Segtree<long, Op>();
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
