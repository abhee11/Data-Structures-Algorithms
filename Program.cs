using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA
{
    class Program
    {

        /* Write a program that sorts an array of integers 
         * using the merge sort algorithm (find it in Wikipedia). */

       

        static void Main()
        {
            int[] array = new int[] {9,3,5,1,2,6, 4, 11, 2, 21, 0, 7, 12, 16, 3, -1};
            //Class1.PrintTables();
            LinkedList.Node trying1 = new LinkedList.Node()
            {
                data = "Abhinav"
            };


        /*    Trees.BinaryTree myTree = new Trees.BinaryTree();
            Trees.AddElement(myTree, 8);
            Trees.AddElement(myTree, 5);
            Trees.AddElement(myTree, 9);
            Trees.AddElement(myTree, 2);
            Trees.AddElement(myTree, 11);
            Trees.AddElement(myTree, 16);
            Trees.AddElement(myTree, 6);
            Trees.AddElement(myTree, 1);
            Trees.AddElement(myTree, 10);
            Trees.FindMinimum(myTree);
            Trees.FindMaximum(myTree);
            Trees.SearchNode(myTree, 21);
            //LinkedList link = new LinkedList();
            //link.Append("Abhinav");
            //link.Append("Maya");
            //link.FindNode("Maya");
            //link.DeleteNode(link.First);
            //Console.Write(link.First.data);
            //Class1.ReverseString("Abhinav is awesome!");
           // Class1.ImplementHashTableinCSharp();
         * */

          /*  HashTable.HashTableUsingArray table = new HashTable.HashTableUsingArray();
            table.Put(0, "Pushpa Mathur");
            table.Put(1, "Sunil Mathur");
            table.Put(2, "Suman Mathur");
            table.Put(3, "Sandhaya Mathur");
            table.Put(4, "Deepali Mathur");
            table.Put(5, "Seema Mathur");
            table.Put(6, "Maya Mathur");
            table.Put(7, "Aakash Mathur");
            table.Get(3);
           */
           // Sort merge = new Sort();
            //int[] res = new int[array.Length];
            //array = Sort.MergeSort(array);
            //Sort.QuickSort(array);
       
            Graphs.graph gr = new Graphs.graph();
            gr.AddConnection(1, 2);
            gr.AddConnection(2, 3);
            gr.AddConnection(3, 4);
            gr.AddConnection(3, 5); 
            gr.AddConnection(1, 6);
            gr.AddConnection(6, 7);
            gr.AddConnection(7, 8);
            gr.AddConnection(7, 9);
            

            Graphs.DFSTraversal(gr);
        /*
          
            StacksAndQueues.Stacks newStack = new StacksAndQueues.Stacks();
            StacksAndQueues.InitializeStack(newStack, 5);
            StacksAndQueues.PushOntoStack(newStack, 10);
            StacksAndQueues.PushOntoStack(newStack, 11);
            StacksAndQueues.PushOntoStack(newStack, 12);
            StacksAndQueues.PushOntoStack(newStack, 13);
            StacksAndQueues.PushOntoStack(newStack, 14);
            StacksAndQueues.PopStack(newStack);
            StacksAndQueues.PopStack(newStack);
            
            StacksAndQueues.Queues newQueue = new StacksAndQueues.Queues(5);
            StacksAndQueues.Enqueue(newQueue, 4);
            StacksAndQueues.Enqueue(newQueue, 3);
            StacksAndQueues.Enqueue(newQueue, 2);

            StacksAndQueues.Dequeue(newQueue);
            StacksAndQueues.Dequeue(newQueue);

            */
            //for(int i =0;i<array.Length ;i++)
            //{
             //   Console.WriteLine("The sorted array is :" + array[i] + "\n");
            //}
        }
    }
}

