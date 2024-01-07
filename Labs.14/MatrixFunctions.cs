using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labs._14
{
    public class MatrixFunctions
    {
        public static int [,] GetRandomMatrix(int rows, int cols)
        {
            if (rows < 0 || cols < 0)
            {
                throw new ArgumentOutOfRangeException(nameof(rows) + " or " + nameof(cols));
            }

            var matrix = new int[rows, cols];

            var random = new Random();
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    matrix[i, j] = random.Next(-10, 10);
                }
            }

            return matrix;
        }

        public static int GetColumnNumberWithZero(int[,] matrix)
        {
            for (int i = 0; i < matrix.GetLength(1); i++)
            {
                for (int j = 0; j < matrix.GetLength(0); j++)
                {
                    if (matrix[j, i] == 0)
                    {
                        return i;
                    }
                }
            }

            return -1;
        }

        public static int[,] GetSortedMatrix(int[,] matrix)
        {
            Dictionary<int, int> sumResults = new Dictionary<int, int>();
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                int sum = 0;
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    if (matrix[i, j] < 0 && matrix[i, j] %2 == 0)
                    {
                        sum = sum + matrix[i, j];
                    }
                }
                sumResults.Add(i, sum);
            }

            var orderList = sumResults.OrderByDescending(x => x.Value).Select(x => x.Key).ToArray();
            var result = new int[matrix.GetLength(0), matrix.GetLength(1)];
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                var rowNumber = orderList[i];
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    result[i, j] = matrix[rowNumber, j];
                }
            }

            return result;
        }
    }
}
