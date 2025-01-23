using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace algo.leetcode
{
    internal class lc_200
    {
        int nVert = 0;
        const int nMax = 100;
        const int mMax = 100;

        void dfs(ref char[][] grid, int i, int j)
        {
            int n = grid.Length;
            int m = grid[0].Length;

            if (i < 0 || i == n)
                return;
            if (j < 0 || j == m)
                return;
            if (grid[i][j] == '0')
                return;

            grid[i][j] = '0';
            dfs(ref grid, i, j + 1);
            dfs(ref grid, i + 1, j);
            dfs(ref grid, i, j - 1);
            dfs(ref grid, i - 1, j);
        }
        public int NumIslands(char[][] grid)
        {
            int n = grid.Length;
            int m = grid[0].Length;

            for (int i = 0; i < n; i++) { 
                for (int j = 0;j < m;++j)
                {
                    if (grid[i][j]=='1')
                    {
                        nVert += 1;
                        dfs(ref grid, i, j + 1);
                        dfs(ref grid, i + 1, j);
                        dfs(ref grid, i, j - 1);
                        dfs(ref grid, i - 1, j);
                    }
                }
            }

            return nVert;
        }
    }
}
