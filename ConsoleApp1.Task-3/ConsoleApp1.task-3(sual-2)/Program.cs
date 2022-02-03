using System;

namespace ConsoleApp1.task_3_sual_2_
{
    internal class Program
    {/*
      verilmihs 6 reqemli ededin ilk 3 denesinin reqemleri cemi tap: example: 123600= 1+2+3
      */
        static void Main(string[] args)
        {
            int a = 234567;
            if (a > 100000 && a < 1000000)
                a = a / 1000;

            {
                int cem = 0;
                int qaliq;
                while (a >0)
                {
                    qaliq = a % 10;
                    a = (a - qaliq) / 10;
                    cem = cem + qaliq;
                    
                }
                Console.WriteLine(cem);
            }
        }
    }
}
