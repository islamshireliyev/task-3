using System;

namespace ConsoleApp1.task_3_sual_12_
{/*
  12) 2 dene 5 reqemli eded daxil et.
    I ededin reqemleri ceminin usutne
    II ededin reqemleri hasilini gel.
    Neticenin axirina I ededin en axiinci reqemini artir.
  */
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 12345;
            int b = 23456;
            if (a>=10000 && a<100000)
            {
                int cem = 0;                           
                int qaliq;
                while (a > 0)
                {
                    qaliq = a % 10;
                    a = (a - qaliq) / 10;
                    cem = cem + qaliq;
                }
                Console.WriteLine(cem);
            }

            if (b >= 10000 && b < 100000)
            {
                  int hasil = 0;
                   int qaliq1;
                while (b > 10000 && b < 100000)
                {
                    qaliq1 = b % 10;
                    b = (b - qaliq1) / 10;
                    hasil = hasil * qaliq1;


                }
                Console.WriteLine(hasil);

            }





        }
    }
}
