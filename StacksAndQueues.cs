using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA
{
    public class StacksAndQueues
    {
        public class Stacks
        {
            public int[] capacity;
            public int top = 0;
        }

        public static void InitializeStack(Stacks s, int cap)
        {
            if (s == null)
            {
                s = new Stacks();
            }
            s.capacity = new int[cap];
        }

        public static void PushOntoStack(Stacks s, int num)
        {
            int stackPos;
            if (s.top == 0)
            {
                s.top = num;
                s.capacity[0] = num;
                return;
            }
            else
            {
                stackPos = 1;
                while (s.capacity[stackPos] != 0 && stackPos < s.capacity.Length)
                {
                    stackPos++;
                }
                if (s.capacity[stackPos] == 0)
                {
                    for (int i = stackPos; i > 0; i--)
                    {
                        s.capacity[i] = s.capacity[i - 1];
                    }
                }
            }

            s.top = num;
            s.capacity[0] = num;
        }

        public static int PopStack(Stacks s)
        {
            if (s.top == 0)
            {
                Console.WriteLine("The stack is empty");
                return 0;
            }
            else
            {
                int res = s.top;
                int j = 0;
                while (s.capacity[j] != 0 && j < s.capacity.Length - 1)
                {
                    j++;
                }
                for (int i = 1; i <= j; i++)
                {
                    s.capacity[i - 1] = s.capacity[i];
                }
                s.capacity[j] = 0;
                s.top = s.capacity[0];
                return res;
            }
        }

        public class Queues
        {
            public int[] queue;
            public int endLine = 0;

            public Queues(int size)
            {
                this.queue = new int[size];
                this.endLine = 0;
            }
        }

        public static void Enqueue(Queues q, int num)
        {
            if (q == null)
            {
                q = new Queues(4);
            }
            else
            {
                int pos = 0;
                while (q.queue[pos] != 0 && pos < q.queue.Length-1)
                {
                    pos++;
                }
                q.queue[pos] = num;
                q.endLine = q.queue[0];
            }
        }

        public static int Dequeue(Queues q)
        {
            if(q.endLine == 0)
            {
                Console.WriteLine("The queueue is empty");
                return 0;
            }

            else
            {
                int pos =0;
                while(q.queue[pos] !=0 && pos< q.queue.Length-1)
                {
                    pos++;
                }
                for(int i=0;i<pos;i++)
                {
                    q.queue[i] = q.queue[i + 1];
                }
                q.endLine = q.queue[0];
                return q.endLine;
            }
        }
    }
}
