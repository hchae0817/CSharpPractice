using System;
using System.Xml.Linq;

namespace Graph
{
	public static class IslandFinder
    {

        //grid = [
        //  ['1','1','0'],
        //  ['1','0','0'],
        //  ['0','0','1']
        //]

        public static int NumIslands(char[][] grid)
        {
            int count = 0;

            for (int row = 0; row < grid.Length; row++)
            {
                for (int col = 0; col < grid[0].Length; col++)
                {
                    if (grid[row][col] == '1')
                    {
                        BFS(grid, row, col);  // Visit all land connected to this cell
                        count++;
                    }
                }
            }

            return count;
        }

        private static void BFS(char[][] grid, int startRow, int startCol)
        {
            var queue = new Queue<(int, int)>();
            queue.Enqueue((startRow, startCol));
            grid[startRow][startCol] = '0';  // Mark visited

            int[][] directions = new int[][]
            {
                new int[] {0, 1},   // right
                new int[] {0, -1},  // left
                new int[] {1, 0},   // down
                new int[] {-1, 0}   // up
            };

            while (queue.Count > 0)
            {
                var (row, col) = queue.Dequeue();

                foreach (var dir in directions)
                {
                    int newRow = row + dir[0];
                    int newCol = col + dir[1];

                    if (IsInBounds(grid, newRow, newCol) && grid[newRow][newCol] == '1')
                    {
                        queue.Enqueue((newRow, newCol));
                        grid[newRow][newCol] = '0';  // Mark as visited
                    }
                }
            }
        }

        private static bool IsInBounds(char[][] grid, int r, int c)
        {
            return r >= 0 && r < grid.Length && c >= 0 && c < grid[0].Length;
        }

    }
}

