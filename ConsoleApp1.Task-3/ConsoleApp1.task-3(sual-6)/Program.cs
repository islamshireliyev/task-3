using System;

namespace ConsoleApp1.task_3_sual_6_
{/*
  6) verilmihs 8 reqemli ededin ilk I ve axirinci reqemlerini legv et
  */
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 12345678;
            int b;
            int c;
            
            if (a>10000000 && a<1000000000)
            {
                b = (a / 10000000) * 10000000;
                Console.WriteLine(b);
                c = (a - b)/10;
                Console.WriteLine(c);
                
            }
        }
    }
}
