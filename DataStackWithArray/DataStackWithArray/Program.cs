using System;
using System.Collections.Generic;

namespace DataStackWithArray
{

    class Program
    {
        static void Main(string[] args)
        {   
            var neshtSi = new List<int>();
            Stack<int> stack = new Stack<int>();

            stack.Push(10);
            stack.Push(6);
            stack.Push(9);
            stack.Push(2);
            stack.Push(5);
            stack.Push(1);
            stack.Push(3);
            stack.Push(4);
            stack.Push(8);
            stack.Push(5);
            stack.Push(2);


            Console.WriteLine($"Popping {stack.Pop().ToString()}");
            Console.WriteLine($"Peeking {stack.Peek().ToString()}");
            Console.WriteLine($"Popping {stack.Pop().ToString()}");
        }
    }
}
