using System;

namespace ConsoleApp1.task_3_sual_12._1_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 12345;
            int b = 23456;

            int cem = 0;
            int hasil = 0;
            int qaliq1;
            int qaliq;
            while (a > 0)
            {
                qaliq = a % 10;
                a = (a - qaliq) / 10;
                cem = cem + qaliq;
            }
            Console.WriteLine(cem);


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
