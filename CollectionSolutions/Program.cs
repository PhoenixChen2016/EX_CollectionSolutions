using System;

namespace CollectionSolutions
{
    class Program
    {
        static void Main(string[] args)
        {
            // MyArray
            var array = new MyArray();

            array.Insert(0, 1);
            array.Insert(1, 2);
            array.Insert(2, 3);

            Console.WriteLine(string.Join(", ", array.ToArray()));

            // MyStack
            var stack = new MyStack();

            stack.Push(10);
            stack.Push(20);
            stack.Push(30);


            if (stack.Length > 0)
                Console.WriteLine(stack.Pop());
        }
    }
}
