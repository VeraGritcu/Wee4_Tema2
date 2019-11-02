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

            Stack myStack = new Stack(5);
            myStack.Push(10);
            myStack.Push(15);
            myStack.Push(20);
            myStack.Pop();
            myStack.Pop();
            myStack.Pop();
            myStack.Pop();
            myStack.Pop();
            myStack.Pop();
            myStack.Print();
            Console.ReadKey();

            
        }
    }
}
