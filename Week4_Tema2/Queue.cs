using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week4_Tema2
{
    internal class Queue
    {
        public Queue(object x)
        {
            QueueSequence = new LinkedList<object>();
            QueueSequence.AddFirst(x);
        }
        private LinkedList<object> QueueSequence { get; set; }

        internal void Enqueue(object x)
        {
            QueueSequence.AddFirst(x);
        }

        internal void Dequeue()
        {
            QueueSequence.RemoveLast();
        }

        internal void Print()
        {
            foreach (object item in QueueSequence)
            {
                Console.WriteLine(item);
            }
        }
    }
}
