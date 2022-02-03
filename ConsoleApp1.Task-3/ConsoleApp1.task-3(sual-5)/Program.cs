using System;

namespace ConsoleApp1.task_3_sual_5_
{/*
  5) verilmihs 6 reqemli ededin 1 ci reqemini hemin ededin axirina at.
  */
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 123456;
            int b;
            int c;
            int d;
            if (a>100000 && a<1000000)
            {
                b = a / 100000;
                c = (a / 100000) * 100000;                                           
                d = a - c;
                d = (d*10) + b;
                Console.WriteLine(d);

            }
        }
    }
}
