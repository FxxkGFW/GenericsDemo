using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningGenerics
{
    class Program
    {
        static void Main(string[] args)
        {
            MyStack<int> stack1 = new MyStack<int>(5);
            stack1.Push(1);
            stack1.Push(2);
            stack1.Push(3);
            stack1.Push(4);
            stack1.Push(5);
            stack1.Push(6);
            Console.WriteLine(stack1.Pop());
            Console.WriteLine(stack1.Pop());
            Console.WriteLine(stack1.Pop());
            Console.WriteLine(stack1.Pop());
            Console.WriteLine(stack1.Pop());
            Console.WriteLine(stack1.Pop());
            MyStack<string> stack2 = new MyStack<string>(5);
            stack2.Push("产品1");
            stack2.Push("产品2");
            stack2.Push("产品3");
            stack2.Push("产品4");
            stack2.Push("产品5");
            stack2.Push("产品6");
            Console.WriteLine(stack2.Pop());
            Console.WriteLine(stack2.Pop());
            Console.WriteLine(stack2.Pop());
            Console.WriteLine(stack2.Pop());
            Console.WriteLine(stack2.Pop());
            Console.WriteLine(stack2.Pop());
            Console.Read();
        }
    }
}
