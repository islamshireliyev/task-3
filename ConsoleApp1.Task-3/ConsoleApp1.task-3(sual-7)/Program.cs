using System;

namespace ConsoleApp1.task_3_sual_7_
{/*
  7) verilmihs 4 reqemli ededin tersine duzub axirina ve evveline 8 artir
  */
    internal class Program
    {
        static void Main(string[] args)
        {
            ulong a = 1234;
            bool ugurludur = (a >= 1000 && a < 10000);
            if (!ugurludur)
            {
                return;
            }
            ulong counter = 1;
            ulong yenieded = 0;

            while (a>0)
            {
                ulong qaliq = a % 10;
                a = a / 10;
                Console.WriteLine(a);

                if (counter%2!=0)
                {
                    yenieded = yenieded * 10 + qaliq;
                }
                

                

            }
                 Console.WriteLine(yenieded);
            yenieded = ((80000 + yenieded) * 10) + 8;
            Console.WriteLine(yenieded);
            
        }
    }
}
