using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA
{
    class SearchOPerations
    {
        public static void LinearSearch(int item, int[] searchArray)
        {
            bool itemFound = false;
            for (int i = 0; i < searchArray.Length; i++)
            {
                Console.WriteLine("\nThe array to look for in is :" + searchArray[i]);
                if (searchArray[i] == item)
                {
                    itemFound = true;
                    Console.WriteLine("\n Item found and is equals to:" + searchArray[i] + " at location:" + i);
                }
            }
            if (!itemFound)
            {
                Console.WriteLine("\n Item does not exist in the array set");
            }
        }

        public static void MergeSort()
        {
            int[] a = new int[8]{9,3,5,1,2,6,11,4};
            SortAndMerge(a);
            for(int i=0;i<a.Length;i++)
            {
                Console.WriteLine("\n The sorted array is :"+ a[i]);
            }

        }

        static void SortAndMerge(int[] a)
        {
            double exp=0;
            
            int j = 1;
            while (j <a.Length)
            {
                for (int i = j-1; i < j; i = i + j)
                {
                    for (int x = 0; x < i; x++)
                    {
                        if (a[x] > a[x + i])
                        {
                            Swap(a, x, x + i);
                        }
                    }
                }
                exp++;
                j = j+(int)Math.Pow(2, exp);
            }

        }

        static int[] Swap(int[] a, int x, int y)
        {
            int temp = 0;
            temp = a[x];
            a[x] = a[y];
            a[y] = temp;

            return a;
        }
       
    }
}
