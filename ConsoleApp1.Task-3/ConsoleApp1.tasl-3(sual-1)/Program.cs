  using System;

namespace ConsoleApp1.tasl_3_sual_1_
{/*
  1) verilmish 4 reqemli ededin reqemlerinin cemini tap

  */
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 1234;
           
            if (a>=1000 && a<=10000)
            {
               int cem = 0;
                int qaliq;
                while (a>0)
                {
                    qaliq = a % 10;
                    a = (a - qaliq) / 10;
                    cem = cem + qaliq;
                }
                Console.WriteLine(cem);
            }
            else
            {
                Console.WriteLine("4 reqemli deyil");
            }

        }
    }
}
