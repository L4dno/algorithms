using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace algo.leetcode
{
    internal class lc_155
    {
        public class MinStack
        {
            Stack <(int,int)> valAndMin;
            public MinStack()
            {
                valAndMin = new Stack<(int, int)>();
            }

            public void Push(int val)
            {
                int min = valAndMin.Count > 0 ? valAndMin.Peek().Item2 : val;
                valAndMin.Push((val, Math.Min(val, min)));
            }

            public void Pop()
            {
                valAndMin.Pop();
            }

            public int Top()
            {
                return valAndMin.Peek().Item1;
            }

            public int GetMin()
            {
                return valAndMin.Peek().Item2;
            }
        }
    }
}
