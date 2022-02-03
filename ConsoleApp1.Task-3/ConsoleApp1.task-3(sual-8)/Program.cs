using System;

namespace ConsoleApp1.task_3_sual_8_
{/*
  8) Verilmis ededdin axirdan 3-cu reqemi ile sonuncu reqeminin cemini tap  1234567
  */
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 1234567;//5
            int b;
            int c;
            int d;
            int e;
            int f;

            if (a>=1000000 && a<10000000)
            {
                b = (a-(a / 1000)*1000)/100;
                 Console.WriteLine(b);
                c = a - (a / 10) * 10;
                d = b + c;
                Console.WriteLine(d);
            }
        }  
    }
}
