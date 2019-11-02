using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week4_Tema2
{
    internal class Queue
    {
        public Queue(int x)
        {
            QueueSequence = new LinkedList<int>();
            QueueSequence.AddFirst(x);
        }
        private LinkedList<int> QueueSequence { get; set; }

        internal void Enqueue(int x)
        {
            QueueSequence.AddFirst(x);
        }

        internal void Dequeue()
        {
            if (QueueSequence.Count > 0)
            {
                QueueSequence.RemoveLast();
            }

        }

        internal void Print()
        {
            if (QueueSequence.Count>0)
            {
                Console.Write($"Your current elements in queue are: ");
                foreach (object item in QueueSequence)
                {
                    Console.Write($"[{item}] ");
                }
            }
            else
            {
                Console.WriteLine("\nNo elements available in queue.");
            }
           
        }
    }
}
