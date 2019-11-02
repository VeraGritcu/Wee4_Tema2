using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week4_Tema2
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue myQueue = new Queue(1);
            myQueue.Enqueue(2);
            myQueue.Enqueue(3);
            myQueue.Enqueue(4);
            myQueue.Dequeue();
            myQueue.Print();
            Console.ReadKey();

            
        }
    }
}
