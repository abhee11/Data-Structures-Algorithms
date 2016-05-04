using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA
{
    class Graphs
    {
       public class graphNode
        {
            public int vertex;
            public graphNode next = null;
       }
       public graphNode root = null;

       public graphNode AddgraphNode(graphNode node, int data)
       {
           while(node!=null)
           {
               node = node.next;
           }
           node = new graphNode()
           {
               vertex = data

           };
           return node;
       }

       public class graph
       {

           public int numVertex;
           public graphNode[] vertexArray;

           int GetVertex()
           {
               Console.WriteLine("Please Enter the number of vertices you need th graph for:");
               Int32.TryParse(Console.ReadLine(), out this.numVertex);
               return numVertex;
           }

           public graph()
           {
               GetVertex();
               vertexArray = new graphNode[numVertex];
               for (int i = 0; i < numVertex; i++)
               {
                   vertexArray[i] = new graphNode() { vertex = i + 1 };
                   Console.WriteLine(vertexArray[i]);
               }
           }

           public void AddConnection(int src, int destination)
           {
               int i = 0;
               while (vertexArray[i].vertex != src && i < vertexArray.Length-1)
               {
                   i++;
               }
               graphNode curr = vertexArray[i]; 
               if (curr.vertex == src)
               {
                   while(curr.next!=null)
                   {
                       curr = curr.next;
                   }
                   curr.next = new graphNode(){
                       vertex = destination
                   };
               }

               else
               {
                   Console.WriteLine("No source vertex found");
               }
           }


       }

       public static void DFSTraversal(graph g)
       {

           bool[] visited = new bool[g.vertexArray.Length];
           for (int i = 0; i < visited.Length; i++)
           {
               visited[i] = false;
           }
           StacksAndQueues.Stacks s = new StacksAndQueues.Stacks();
           StacksAndQueues.InitializeStack(s, g.vertexArray.Length);

           graphNode startPoint = g.vertexArray.First();
           graphNode currPoint = g.vertexArray.First();
           visited[0] = true;
           int pos = 1;
           StacksAndQueues.PushOntoStack(s, currPoint.vertex);
           while (s.top != 0)
           {
               while (currPoint.next != null && pos < g.vertexArray.Length)
               {
                   if (!visited[currPoint.next.vertex - 1])
                   {
                       StacksAndQueues.PushOntoStack(s, currPoint.next.vertex);
                       visited[currPoint.next.vertex - 1] = true;
                       Console.WriteLine("The vertex " + currPoint.vertex + " was pushed onto the stack and is marked as visited\n");
                       Console.WriteLine("The vertex " + currPoint.next.vertex + " is visited");
                       currPoint = g.vertexArray[currPoint.next.vertex - 1];
                       Console.WriteLine("tHE STACK top IS " + s.top);
                       pos++;
                   }
                   else if (visited[currPoint.next.vertex - 1])
                   {
                       currPoint = currPoint.next;
                       visited[currPoint.vertex - 1] = true;
                   }
               }
               StacksAndQueues.PopStack(s);
               if(s.top!=0)
               currPoint = g.vertexArray[s.top-1];
               
               Console.WriteLine("The first depth is done, retrackting to " + currPoint.vertex);
           }

           Console.WriteLine("The depth search is complete");
       }
    }
}
