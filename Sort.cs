using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA
{
    public class Sort
    {
         public static int[] MergeSort(int[] array)
        {
            // If list size is 0 (empty) or 1, consider it sorted and return it
            // (using less than or equal prevents infinite recursion for a zero length array).
            if (array.Length <= 1)
            {
                return array;
            }

            // Else list size is > 1, so split the list into two sublists.
            int middleIndex = (array.Length) / 2;
            int[] left = new int[middleIndex];
            int[] right = new int[array.Length - middleIndex];

            Array.Copy(array, left, middleIndex);
            Array.Copy(array, middleIndex, right, 0, right.Length);

            // Recursively call MergeSort() to further split each sublist
            // until sublist size is 1.
            left = MergeSort(left);
            right = MergeSort(right);

            // Merge the sublists returned from prior calls to MergeSort()
            // and return the resulting merged sublist.
            return Merge(left, right);
        }

        public static int[] Merge(int[] left, int[] right)
        {
            // Convert the input arrays to lists, which gives more flexibility 
            // and the option to resize the arrays dynamically.
            List<int> leftList =  left.ToList<int>();
            List<int> rightList = right.ToList<int>();
            List<int> resultList = new List<int>();

            // While the sublist are not empty merge them repeatedly to produce new sublists 
            // until there is only 1 sublist remaining. This will be the sorted list.
            while (leftList.Count > 0 || rightList.Count > 0)
            {
                if (leftList.Count > 0 && rightList.Count > 0)
                {
                    // Compare the 2 lists, append the smaller element to the result list
                    // and remove it from the original list.
                    if (leftList[0] <= rightList[0])
                    {
                        resultList.Add(leftList[0]);
                        leftList.RemoveAt(0);
                    }

                    else
                    {
                        resultList.Add(rightList[0]);
                        rightList.RemoveAt(0);
                    }
                }

                else if (leftList.Count > 0)
                {
                    resultList.Add(leftList[0]);
                    leftList.RemoveAt(0);
                }

                else if (rightList.Count > 0)
                {
                    resultList.Add(rightList[0]);
                    rightList.RemoveAt(0);
                }
            }

            // Convert the resulting list back to a static array
            int[] result = resultList.ToArray();
            return result;
        }

        public static int[] QuickSort(int[] a)
        {
            int originalLength = a.Length;
            //Array.Copy(a, result, a.Length);
            Partition(a, 0, a.Length-1);
            return a;
        }

        public static void Partition(int[] a, int left, int right)
        {
            
            if(left >= right)
            {
                return;
            }
            int pivot = a[right];
            int pos = left;

            for(int i =left; i<right;i++)
            {
                if(a[i] <= pivot)
                {
                    Swap(pos, i, a);
                    pos++;
                }
            }
            Swap(right, pos, a);
            Partition(a, 0, pos - 1);
            Partition(a, pos+1, right);
        }

        public static int[] Swap(int indexCurr, int someIndex, int[] a)
        {
            int temp = a[indexCurr];
            a[indexCurr] = a[someIndex];
            a[someIndex] = temp;
            return a;
        }
    }
}
