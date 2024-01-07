using System.ComponentModel.DataAnnotations;

namespace Labs._14
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите размер массива: ");

            int size = int.Parse(Console.ReadLine());

            var array = ArrayFunctions.GetRandomArray(size);

            Console.WriteLine("Исходный массив: ");
            PrintVector(array);

            Console.WriteLine("Введите число X:");
            int.TryParse(Console.ReadLine(), out int x);

            int count = ArrayFunctions.CountGreaterThen(array, x);
            Console.WriteLine($"Количество элементов массива больших {x} равно {count}");

            int productArray = ArrayFunctions.GetProductArrayAfterMax(array);
            Console.WriteLine($"Произведение элементов массива, расположенных после максимального элемента: {productArray}");

            Console.WriteLine("После сортировки по возрастанию:");
            var sortedArray = ArrayFunctions.SortArray(array);
            PrintVector(sortedArray);

            Console.WriteLine("Часть 2:");
            Console.WriteLine("Введите количество стоблцов:");
            int.TryParse(Console.ReadLine(), out int columns);

            Console.WriteLine("Введите количество строк:");
            int.TryParse(Console.ReadLine(), out int rows);
            var matrix = MatrixFunctions.GetRandomMatrix(rows, columns);

            PrintMatrix(matrix);

            int column = MatrixFunctions.GetColumnNumberWithZero(matrix);
            if (column == -1)
            {
                Console.WriteLine("Нет столбцов, где хотя бы один элемент равено 0");
            }
            else
            {
                Console.WriteLine("Номер столбца, в котором есть хотя бы один нулевой элемент: " + column);
            }
            
            Console.WriteLine("Отсортированная матрица:");
            var newMatrix = MatrixFunctions.GetSortedMatrix(matrix);
            PrintMatrix(newMatrix);
        }

        static void PrintVector(IEnumerable<int> vector)
        {
            Console.WriteLine(string.Join(" ", vector));
        }

        static void PrintMatrix(int[,] matrix)
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.Write(" {0}", matrix[i, j]);
                }

                Console.WriteLine();
            }
        }
    }
}
