using System;

namespace ConsoleApp1.Task_3
{
    /*
     9) 9 reqemli ededdin tek yerde dayananlardan bir eded duzlet: 132346389=12439
     */
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 123456789;

            bool ugurludur = (a >= 100000000 && a < 1000000000);

            if (!ugurludur)

            {
                Console.WriteLine("9 reqemli deyil");
                return;


            }
                int counter = 1;
               
                int yenieded = 0;

            while (a > 0)
            {
                int qaliq = a % 10;
                a = a / 10;

                if (counter % 2 != 0)
                {
                    yenieded = yenieded * 10 + qaliq;
                }


                counter++;
            }
                Console.WriteLine(yenieded);
                
                
            

            while (yenieded>0)
            {
                 int qaliq = yenieded % 10;
                yenieded = yenieded / 10;
                a = a * 10 + qaliq;

                


                

            }
            Console.WriteLine(a);
            
        } 
    }
}
