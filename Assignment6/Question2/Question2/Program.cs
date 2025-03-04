using Day_6_Assignment_Queue.Model;

namespace Day_6_Assignment_Queue
{
    internal class Program
    {
        static void Main(string[] args)
        {
            TokenQueue queue = new TokenQueue();
            queue.Enqueue("Vaish");
            queue.Enqueue("Say");
            queue.Enqueue("Diya");

            Console.WriteLine($"Next in Line: {queue.Peek()}");

            queue.Dequeue();
            queue.Dequeue();

            Console.WriteLine($"Next in Line: {queue.Peek()}");
            queue.Dequeue();
            queue.Dequeue();
        }
    }
}