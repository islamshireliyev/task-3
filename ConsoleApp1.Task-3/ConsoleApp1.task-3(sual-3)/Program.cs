using System;

namespace ConsoleApp1.task_3_sual_3_
{/*
  verilmihs 9 reqemli ededin duz ortaya dushen 3 reqeminin reqemleri cemi
  */
    internal class Program
    {
        static void Main(string[] args)
        {

            int a = 123456789;
            int b;
            int c;
            if (a>100000000 && a<1000000000)
            {
                a = a / 1000;
                int cem = 0;
                int qaliq;
                Console.WriteLine(a);
              
               
                b = (a / 1000)*1000;
                Console.WriteLine(b);

                c = a - b;
                Console.WriteLine(c);
                while (c > 0)
                {
                    qaliq = c % 10;
                    c=(c-qaliq)/10;
                    cem = cem + qaliq;

                }

                Console.WriteLine(cem);
            }

        }
    }
}
