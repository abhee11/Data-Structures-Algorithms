using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA
{
    class ArrayOperation
    {
        public static int[] Insert(int numberToInsert, int location, int[] arr)
        {
            int[] arrN = new int[arr.Length + 1];
            for (int i = 0; i < location; i++)
            {
                arrN[i] = arr[i];
            }
            for (int i = arrN.Length - 1; i > location; i--)
            {
                arrN[i] = arr[i - 1];
            }
            arrN[location] = numberToInsert;
            for (int i = 0; i < arrN.Length; i++)
            {
                Console.WriteLine("\nThe new Array is :" + arrN[i]);
            }
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine("\nThe old array insertion is :" + arr[i]);
            }
            return arr;
        }
    }
}
