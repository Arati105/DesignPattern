using System;
using System.Collections.Generic;

namespace GenericQueueApp
{
    class Program
    {
        static void Main(string[] args)
        {
            IQueue<int> numbers = new MyQueue<int>();
            numbers.Enqueue(100);
            numbers.Enqueue(200);
            numbers.Enqueue(300);

            //Part-1
            Console.WriteLine(numbers.Count());
            Console.WriteLine(numbers.Dequeue());
            Console.WriteLine(numbers.Count());

            //Part-2
            PrintDetail(numbers);
            PrintDetailWithoutForEach(numbers);
        }
        private static void PrintDetail(IQueue<int> queue)
        {
            Console.WriteLine("\n Using ForEach:");
            foreach (var item in queue) Console.WriteLine(item);
        }
        private static void PrintDetailWithoutForEach(IQueue<int> queue)
        {
            Console.WriteLine("\n Not Using ForEach:");
            IEnumerator<int> iterator = queue.GetEnumerator();
            while(iterator.MoveNext())
            {
                Console.WriteLine(iterator.Current);
            }
        }
    }
}
