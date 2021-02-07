using AtCoder;
using AtCoder.Internal;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Runtime.Intrinsics.X86;
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
#region Expanded by https://github.com/naminodarie/SourceExpander
namespace AtCoder{public interface ISegtreeOperator<T>{T Identity{get;}T Operate(T x,T y);}public class Segtree<TValue,TOp>where TOp:struct,ISegtreeOperator<TValue>{private static readonly TOp op=default;public int Length{get;}internal readonly int log;internal readonly int size;public readonly TValue[]d;public Segtree(int n){Length=n;log=InternalBit.CeilPow2(n);size=1<<log;d=new TValue[2*size];Array.Fill(d,op.Identity);}public Segtree(TValue[]v):this(v.Length){for(int i=0;i<v.Length;i++)d[size+i]=v[i];for(int i=size-1;i>=1;i--){Update(i);}}[MethodImpl(MethodImplOptions.AggressiveInlining)]public void Update(int k)=>d[k]=op.Operate(d[2*k],d[2*k+1]);public TValue this[int p]{[MethodImpl(MethodImplOptions.AggressiveInlining)]set{p+=size;d[p]=value;for(int i=1;i<=log;i++)Update(p>>i);}[MethodImpl(MethodImplOptions.AggressiveInlining)]get{return d[p+size];}}[MethodImpl(MethodImplOptions.AggressiveInlining)]public TValue Slice(int l,int len)=>Prod(l,l+len);[MethodImpl(MethodImplOptions.AggressiveInlining)]public TValue Prod(int l,int r){TValue sml=op.Identity,smr=op.Identity;l+=size;r+=size;while(l<r){if((l&1)!=0)sml=op.Operate(sml,d[l++]);if((r&1)!=0)smr=op.Operate(d[ --r],smr);l>>=1;r>>=1;}return op.Operate(sml,smr);}public TValue AllProd=>d[1];public int MaxRight(int l,Predicate<TValue>f){if(l==Length)return Length;l+=size;var sm=op.Identity;do{while(l%2==0)l>>=1;if(!f(op.Operate(sm,d[l]))){while(l<size){l=(2*l);if(f(op.Operate(sm,d[l]))){sm=op.Operate(sm,d[l]);l++;}}return l-size;}sm=op.Operate(sm,d[l]);l++;}while((l&-l)!=l);return Length;}public int MinLeft(int r,Predicate<TValue>f){if(r==0)return 0;r+=size;var sm=op.Identity;do{r--;while(r>1&&(r%2)!=0)r>>=1;if(!f(op.Operate(d[r],sm))){while(r<size){r=(2*r+1);if(f(op.Operate(d[r],sm))){sm=op.Operate(d[r],sm);r--;}}return r+1-size;}sm=op.Operate(d[r],sm);}while((r&-r)!=r);return 0;}private struct DebugItem{public DebugItem(int l,int r,TValue value){if(r-l==1)key=$"[{l}]";else key=$"[{l}-{r})";this.value=value;}private readonly string key;private readonly TValue value;}private class DebugView{private readonly Segtree<TValue,TOp>segtree;public DebugView(Segtree<TValue,TOp>segtree){this.segtree=segtree;}public DebugItem[]Items{get{var items=new List<DebugItem>(segtree.Length);for(int len=segtree.size;len>0;len>>=1){int unit=segtree.size/len;for(int i=0;i<len;i++){int l=i*unit;int r=Math.Min(l+unit,segtree.Length);if(l<segtree.Length)items.Add(new DebugItem(l,r,segtree.d[i+len]));}}return items.ToArray();}}}}}
namespace SourceExpander{public class Expander{[Conditional("EXP")]public static void Expand(string inputFilePath=null,string outputFilePath=null,bool ignoreAnyError=true){}public static string ExpandString(string inputFilePath=null,bool ignoreAnyError=true){return "";}}}
namespace AtCoder.Internal{public static class InternalBit{[MethodImpl(MethodImplOptions.AggressiveInlining)]public static int ExtractLowestSetBit(int n){if(Bmi1.IsSupported){return(int)Bmi1.ExtractLowestSetBit((uint)n);}return n&-n;}[MethodImpl(MethodImplOptions.AggressiveInlining)]public static int BSF(uint n){return BitOperations.TrailingZeroCount(n);}public static int CeilPow2(int n){var un=(uint)n;if(un<=1)return 0;return BitOperations.Log2(un-1)+1;}}}
#endregion Expanded by https://github.com/naminodarie/SourceExpander
