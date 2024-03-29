﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicDelegates
{
    // declare the delegate type
    public delegate string MyDelegate(int arg1, int arg2);

    class MyClass
    {
        // Delegates can be bound to instance members as well as
        // static class functions
        public string InstanceMethod1(int arg1, int arg2)
        {
            return ((arg1 + arg2) * arg1).ToString();
        }
    }

    class Program
    {
        static string Func1(int a, int b)
        {
            return (a + b).ToString();
        }
        static string Func2(int a, int b)
        {
            return (a * b).ToString();
        }

        static void Main(string[] args)
        {
            MyDelegate f = Func1;
            Console.WriteLine("The number is: " + f(10, 20));
            f = Func2;
            Console.WriteLine("The number is: " + f(10, 20));

            MyClass mc = new MyClass();
            f = mc.InstanceMethod1;
            Console.WriteLine("The number is: " + f(10, 20));

            Console.WriteLine("\nPress Enter Key to Continue...");
            Console.ReadLine();
        }
    }
}
