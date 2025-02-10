using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace algo.leetcode
{
    internal class lc_518
    {
        static public int Change(int amount, int[] coins)
        {
            int nCoins = coins.Length;
            int[,] dp = new int[nCoins + 1, amount + 1];

            // а если у нас любая монета больше amount

            for (int i = 0; i < nCoins; i++)
            {
                if (amount >= coins[i])
                    dp[i+1, coins[i]] = 1;
            }
            for (int i = 1;i <= nCoins; i++)
            {
                for (int j = 1; j<= amount; ++j)
                {
                    dp[i, j] = dp[i - 1, j] + dp[i,int.Max(j - coins[i - 1], 0)] + dp[i, j];
                }
            }
            return dp[nCoins, amount];
        }
    }
}
