using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningGenerics
{
    /// <summary>
    /// 使用泛型类实现出入栈通用类
    /// </summary>
    public class MyStack<T>
    {
        T[] stack;
        int size;//栈数据容量
        int stackPoint;//栈位置指针

        public MyStack(int size)
        {
            this.size = size;
            stack = new T[size];
            stackPoint = -1;
        }
        /// <summary>
        /// 入栈
        /// </summary>
        /// <param name="item"></param>
        public void Push(T item)
        {
            stackPoint++;
            if (stackPoint >= size)
            {
                Console.WriteLine("栈空间已满");
                return;
            }
            stack[stackPoint] = item;
        }
        /// <summary>
        /// 出栈
        /// </summary>
        /// <returns></returns>
        public T Pop()
        {
            stackPoint--;
            if (stackPoint < 0)
            {
                Console.WriteLine("栈空间已空");
                return default(T);
            }
            T data = stack[stackPoint];
            return data;
        }
    }
}
