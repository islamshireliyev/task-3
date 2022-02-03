using System;

namespace ConsoleApp1.task_3_sual_4_
{/*
   verilmihs 5 reqemli ilk ve son reqemlerinin ceminin kvadrati
  */
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 12345;
            int b;
            int c;
            int d;
            int e;
            int f;
            if (a>10000 && a<100000)
            {
                b = (a / 10) * 10;
                Console.WriteLine(b);
                c = a - b;
                Console.WriteLine(c);
                d = (a / 10000);
                Console.WriteLine(d);
                e=(c+d)*(c+d);
                Console.WriteLine(e);
            }




        }        
    }
}
