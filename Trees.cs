using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA
{
    public class Trees
    {
        public class BinaryTree
        {
            public int data;
            public BinaryTree parent;
            public BinaryTree leftTree;
            public BinaryTree rightTree;

        }

        public static void AddElement(BinaryTree tree, int data)
        {
            bool nodeLeftAdded = false;
            bool nodeRightAdded = false;
            if (tree.parent == null)
            {
                tree.data = data;
                tree.parent = tree;
                tree.leftTree = null;
                tree.rightTree = null;
                Console.WriteLine("New element added with data :" + tree.data + "\n");
            }

            else {

                while (!nodeRightAdded && !nodeLeftAdded)
                {

                    if (data < tree.data)
                    {
                        while (data < tree.data && tree.leftTree != null)
                        {
                            tree = tree.leftTree;
                        }
                        if (data < tree.data)
                        {
                            tree.leftTree = new BinaryTree();
                            AddElement(tree.leftTree, data);
                            nodeLeftAdded = true;
                            Console.WriteLine("New element added to left with data:" + data + "\n");
                        }
                    }

                    else if (data > tree.data)
                    {
                        while (data > tree.data && tree.rightTree != null)
                        {
                            tree = tree.rightTree;
                        }
                        if (data > tree.data)
                        {
                            tree.rightTree = new BinaryTree();
                            AddElement(tree.rightTree, data);
                            nodeRightAdded = true;
                            Console.WriteLine("New element added to right with data :   " + data + "with previous node data \n");
                        }
                    }
                }
            }
        }
        
        public static BinaryTree FindMinimum(BinaryTree tree)
        {
            if(tree.parent == null)
            {
                return null;
            }
            else
            {
                while(tree.leftTree != null)
                {
                    tree = tree.leftTree;
                }
                Console.WriteLine("The minimim data of the node is :" + tree.data);
                return tree;
            }
        }

        public static BinaryTree FindMaximum(BinaryTree tree)
        {
            if (tree.parent == null)
            {
                return null;
            }
            else
            {
                while (tree.rightTree != null)
                {
                    tree = tree.rightTree;
                }
                Console.WriteLine("The maximum data of the node is :" + tree.data);
                return tree;
            }
        }

        public static BinaryTree SearchNode(BinaryTree tree, int data)
        {
            bool nodeFound = false;
            if(tree.parent == null)
            {
                return null;
            }
            else
            {
                while (!nodeFound && tree != null)
                {
                    if (data < tree.data && tree != null)
                    {
                        tree = tree.leftTree;
                        if (tree != null && tree.data == data)
                        {
                            nodeFound = true;
                            Console.WriteLine("The node was found !");
                            return tree;
                        }
                    }
                    else if (data > tree.data )
                    {
                        tree = tree.rightTree;
                        if ( tree != null && tree.data == data)
                        {
                            nodeFound = true;
                            Console.WriteLine("The node was found !");
                            return tree;
                        }
                    }
               
                }
                Console.WriteLine("No node found, Sorry!");
                return tree;
            }
        }
    }
}
