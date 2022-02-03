using System;

namespace ConsoleApp1.task_3_sual_10_
{
    internal class Program
    {/*
      10) 9 reqemli ededdi tek yerde dayananlardan bir eded duzlet,
    sonra cut yerde dayanlarinda bir eded duzlet,
    sonra onlari topla
      */
        static void Main(string[] args)
        {
            
                int a = 123456789;
                int b = a;
                int sum;
                bool ugurludur = (a >= 100000000 && a < 1000000000);



                if (!ugurludur)
                {
                    Console.WriteLine("9 reqemli deyil");
                    return;
                }
                int counter = 1;
                int qaliq;
                int yenieded = 0;

            while (a > 0)
            {
                 qaliq = a % 10;
                a = a / 10;

                if (counter % 2 != 0)
                {
                    yenieded = yenieded * 10 + qaliq;

                }
                counter++;
            }
            Console.WriteLine(yenieded);




            while (yenieded > 0)
            {
                qaliq = yenieded % 10;
                yenieded = yenieded / 10;
                a = a * 10 + qaliq;
            }
            Console.WriteLine(a);


            int counter1 = 0;
            int qaliq1;
            int yenieded1 = 0;


            while (b > 0)
            {
                qaliq1 = b % 10;

                b  /= 10;
                if (counter1 % 2 != 0);
                {
                    yenieded1 = yenieded1 * 10 + qaliq1;
                }
                counter1++;
            }
            Console.WriteLine(yenieded1);

            

            while (yenieded1 > 0)
            {
                qaliq1=yenieded1 % 10;
                yenieded1  /= 10;
                b=b * 10 + qaliq1;
            }
            Console.WriteLine(b);
            sum = a + b;
            Console.WriteLine(sum);

        }
    }
}
