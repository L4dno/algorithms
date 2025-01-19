using System;
using static algo.leetcode.lc_155;

/* 
 * CF Test
 * filename.Solution.Launch() -> Main() when sending
*/


namespace leetcode_solver
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //bool tmp = false;
            //tmp = algo.leetcode.lc_20.IsValid("([)]");
            //Console.WriteLine(tmp);

            MinStack minStack = new MinStack();
            minStack.Push(1);
            minStack.Push(2);
            minStack.Push(0);
            minStack.GetMin(); // return 0
            minStack.Pop();
            minStack.Top();    // return 2
            minStack.GetMin(); // return 1
        }
    }
}
