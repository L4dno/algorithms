using System.Collections.Generic;
public class Solution
{
	public bool isValidBox(char[][] board, int si, int sj)
	{
		HashSet<int> used = new HashSet<int>();
		for (int i = si; i < si + 3; ++i)
		{
			for (int j = sj; j < sj + 3; ++j)
			{
				if (board[i][j] != '.' && used.Contains(board[i][j] - '0'))
					return false;
				used.Add(board[i][j] - '0');
			}
		}
		return true;
	}
	public bool IsValidSudoku(char[][] board)
	{
		const int n = 9;

		HashSet<int> used = new HashSet<int>();

		// checking rows
		for (int i = 0; i < n; ++i)
		{
			for (int j = 0; j < n; ++j)
			{
				if (board[i][j] != '.')
				{
					if (used.Contains(board[i][j] - '0'))
					{
						return false;
					}
					else used.Add(board[i][j] - '0');
				}
			}
			used.Clear();
		}

		// checking columns
		for (int i = 0; i < n; ++i)
		{
			for (int j = 0; j < n; ++j)
			{
				if (board[j][i] != '.')
				{
					if (used.Contains(board[j][i] - '0'))
					{
						return false;
					}
					else used.Add(board[j][i] - '0');
				}
			}
			used.Clear();
		}

		for (int i = 0; i < n; i += 3)
		{
			for (int j = 0; j < n; j += 3)
			{
				if (!isValidBox(board, i, j)) return false;
			}
		}
		return true;
	}
}