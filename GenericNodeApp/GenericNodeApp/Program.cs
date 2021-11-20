using System;

namespace GenericNodeApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Node<string> n1 = new Node<string>();
            n1.Data = "Mumbai";

            Node<string> n2 = new Node<string>();
            n2.Data = "Pune";

            Node<string> n3 = new Node<string>();
            n3.Data = "Nashik";

            n1.Next = n2;
            n2.Next = n3;
            n3.Next = null;
            PrintDetail(n1);
            PrintDetail(n2);

        }
        private static void PrintDetail(Node<string> node1)
        {
            Console.WriteLine(node1.Data);
            Console.WriteLine(node1.Next);
        }
    }
}
