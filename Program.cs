using System;

namespace QueueImplementation
{
    class Program
    {
        static void Main(string[] args)
        {
            UC4LinkedListQueue linkedListQueue = new UC4LinkedListQueue();
            //linkedListQueue.Enqueue(56);
            //linkedListQueue.Enqueue(30);
            //linkedListQueue.Enqueue(70);
            //linkedListQueue.Display();
            _ = new UC4LinkedListQueue();
            linkedListQueue.Dqueue(56);
            linkedListQueue.Dqueue(30);
            linkedListQueue.Dqueue(70);
            linkedListQueue.Display();
        }
    }
}
