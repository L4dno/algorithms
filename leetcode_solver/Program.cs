
namespace leetcode_solver
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < _0049GroupAnagrams.Tcnt; ++i)
            {
                Solution sol = new Solution();
                var res = sol.GroupAnagrams(_0049GroupAnagrams.Inputs[i].ToArray());
                if (res == _0049GroupAnagrams.ExpectedOutputs[i])
                {
                    Console.WriteLine("test {0} chech!\n", i);
                }
                else
                {
                    Console.WriteLine("test {0} failed\n", i);
                    break;
                }
            }
        }
    }
}
