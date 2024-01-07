using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Labs._14
{
    public class ArrayFunctions
    {
        public static int[] GetRandomArray(int length)
        {
            if (length <= 0)
            {
                throw new ArgumentOutOfRangeException(nameof(length));
            }

            var random = new Random();

            int[] array = new int[length];
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = random.Next(-10, 10);
            }

            return array;
        }


        public static int CountGreaterThen(int[] array, int x)
        {
            int result = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] > x)
                {
                    result++;
                }
            }

            return result;
        }

        public static int GetProductArrayAfterMax(int[] array)
        {
            if (array.Length == 0)
            {
                return 0;
            }

            int max = Math.Abs(array[0]);
            int index = 0;
            for (int i = 1; i < array.Length; i++)
            {
                if (Math.Abs(array[i]) > max)
                {
                    max = Math.Abs(array[i]);
                    index = i;
                }
            }

            int result = 1;
            for (int i = index + 1; i < array.Length; i++)
            {
                result *= array[i];
            }

            return result;
        }

        public static int[] SortArray(int[] array)
        {
            Array.Sort(array);
            return array;
        }
    }
}
