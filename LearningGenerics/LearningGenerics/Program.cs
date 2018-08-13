using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningGenerics
{
    class Program
    {
        //static void Main(string[] args)
        //{
        //    MyStack<int> stack1 = new MyStack<int>(5);
        //    stack1.Push(1);
        //    stack1.Push(2);
        //    stack1.Push(3);
        //    stack1.Push(4);
        //    stack1.Push(5);
        //    stack1.Push(6);
        //    Console.WriteLine(stack1.Pop());
        //    Console.WriteLine(stack1.Pop());
        //    Console.WriteLine(stack1.Pop());
        //    Console.WriteLine(stack1.Pop());
        //    Console.WriteLine(stack1.Pop());
        //    Console.WriteLine(stack1.Pop());
        //    MyStack<string> stack2 = new MyStack<string>(5);
        //    stack2.Push("产品1");
        //    stack2.Push("产品2");
        //    stack2.Push("产品3");
        //    stack2.Push("产品4");
        //    stack2.Push("产品5");
        //    stack2.Push("产品6");
        //    Console.WriteLine(stack2.Pop());
        //    Console.WriteLine(stack2.Pop());
        //    Console.WriteLine(stack2.Pop());
        //    Console.WriteLine(stack2.Pop());
        //    Console.WriteLine(stack2.Pop());
        //    Console.WriteLine(stack2.Pop());
        //    Console.Read();
        //}
        static void Main(string[] args)
        {
            //实例化泛型对象
            MyGeneric<int, Course, Teacher> myGeneric = new MyGeneric<int, Course, Teacher>();
            //给对象属性赋值
            myGeneric.ProductList = new List<Course>()
            {
                new Course(){CourseName=".NET",Period=10},
                new Course(){CourseName="SQL Server",Period=20},
                new Course(){CourseName="TypeScript",Period=30}
            };
            myGeneric.Publisher = new Teacher()
            {
                Age = 31,
                Name = "ChenQiao"
            };
            Course course = myGeneric.Buy(1);
            Console.WriteLine($"你买的课程是{course.CourseName},时长为{course.Period}分钟，发布者是{myGeneric.Publisher.Name},年龄{myGeneric.Publisher.Age}岁");
            Console.Read();
        }
    }
    /// <summary>
    /// 添加约束类型的泛型类
    /// </summary>
    /// <typeparam name="T1"></typeparam>
    /// <typeparam name="T2"></typeparam>
    /// <typeparam name="T3"></typeparam>
    class MyGeneric<T1, T2, T3>
        where T1 : struct //
        where T2 : class
        where T3 : new()
    {
        public List<T2> ProductList { get; set; } = new List<T2>();
        public T3 Publisher { get; set; } = new T3();
        //public MyGeneric()
        //{
        //    ProductList = new List<T2>();
        //    Publisher = new T3();
        //}
        public T2 Buy(T1 item)
        {
            dynamic num = item;
            return ProductList[num];
        }
    }
    class Course
    {
        public string CourseName { get; set; }
        public int Period { get; set; }
    }
    class Teacher
    {
        public string Name { get; set; }
        public int Age { get; set; }
    }
}
