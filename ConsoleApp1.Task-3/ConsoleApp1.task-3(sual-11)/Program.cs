using System;

namespace ConsoleApp1.task_3_sual_11_
{/*
  11) 8 reqemli ededin reqemlerini iki -iki qruplashdir.
    Qruplarin cemini tap. Alinan cavabin axirina 99 artir.
    Sonra cavabin ozunden onun 18% ni cix;
  */
    internal class Program
    {
        static void Main(string[] args)
        {
            int a=12345678;
            int b;
            int c;
            int d;
            int e;
            int cem;
            
            if (a >= 10000000 && a < 100000000)
            {
                b = a / 1000000;
                Console.WriteLine(b);
                c = (a / 10000)-(b*100);
                Console.WriteLine(c);
                d= (a /100)-(a/10000)*100;
                Console.WriteLine(d);
                e= a -(a/100)*100;
                Console.WriteLine(e);
                cem = b + c + d + e;
                Console.WriteLine(cem);
                cem = (cem * 100) + 99;
                Console.WriteLine(cem);
                cem = (cem * 18) / 100;
                Console.WriteLine(cem);
            }
         
            
        }
    }
}
