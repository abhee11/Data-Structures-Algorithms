using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

 namespace DSA
{
    public class LinkedList
    {
        public class Node
        {
            public Node next = null;
            public string data;

        }

        public Node root = null;
        public Node First
            {
                get{
                    return root;
                }
            }

        public Node Last
            {
                get
                {
                    Node curr= root;
                    if(curr == null)
                    {
                        return null;
                    }

                    while(curr.next != null)
                    {
                        curr = curr.next;
                    }

                    return curr;
                }
            }
        public void Append(string value)
        {
            
            Node n = new Node { data = value };
            if (root == null)
                root = n;
            else
                Last.next = n;
        }

            public void DeleteNode(Node n)
            {
                Node curr = First;
                Node track = new Node();
                if (curr.next == null)
                {
                    Console.Write("\n No node to delete");
                }
                else
                {
                    while (curr.next != n)
                    {
                        track = curr;
                        curr = curr.next;
                    }

                    track.next = curr.next;
                }
            }

        public Node FindNode(string value)
            {
                Node curr = First;
                if (curr == null)
                {
                    Console.WriteLine(" The linked list is empty \n");
                    return null;
                }
                else
                {
                    while(curr.data != value)
                    {
                        curr = curr.next;
                   
                    }
                    if(curr == null)
                    {
                        Console.WriteLine("The node with the data" + value + "is not found");
                        return null;
                    }
                    Console.WriteLine("The node is found and has the following object data :" + curr.data);
                    return curr;
                }
 
            }
    }
    
}
