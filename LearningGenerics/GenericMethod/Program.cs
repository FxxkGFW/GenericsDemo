using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"10+20={add(10, 20)}");
            Console.WriteLine($"10.5+20.9={add(10.5, 20.9)}");
            Console.WriteLine($"10+20.9={add(10, 20.9)}");
            Console.WriteLine(add("hello", " world"));
            Console.WriteLine("-----------------");
            Console.WriteLine(Sum(100));
            Console.ReadLine();
        }
        //泛型方法简单使用
        static T add<T>(T a, T b)
        {
            dynamic a1 = a;
            dynamic b1 = b;
            return a1 + b1;
        }
        //泛型方法实现一个数求和
        static T Sum<T>(T a) where T : struct
        {
            dynamic sum = default(T);
            for (dynamic i = default(T); i <= a; i++)
            {
                sum += i;
            }
            return sum;
        }
    }
}
