using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeetCode75Solutions.ClassLibrary.HashAndSetsProblems
{
    internal class EqualRowColumnPairs
    {
        public int EqualPairs(int[][] grid)
        {
            Dictionary<int, int[]> columns = new Dictionary<int, int[]>();
            Dictionary<int, int[]> rows = new Dictionary<int, int[]>();
            int res = 0;

            for (int rowIndex = 0; rowIndex < grid.Length; rowIndex++)
            {
                var row = grid[rowIndex];
                if (!rows.ContainsKey(rowIndex))
                    rows[rowIndex] = row;
                for (int columnIndex = 0; columnIndex < row.Length; columnIndex++)
                {
                    var column = row[columnIndex];
                    if (!columns.ContainsKey(columnIndex))
                        columns[columnIndex] = new int[1] { column };
                    else
                    {
                        int[] tempColumn = columns[columnIndex];
                        int[] newColumn = new int[tempColumn.Length + 1];
                        tempColumn.CopyTo(newColumn, 0);
                        newColumn[newColumn.Length - 1] = column;
                        columns[columnIndex] = newColumn;
                    }
                }
            }

            foreach (var row in rows)
            {
                foreach (var column in columns)
                {
                    if (row.Value.SequenceEqual(column.Value))
                        res++;
                }
            }
            return res;
        }
    }
}
