// 4)Verilmis n tam ededinin sade ve ya murekkeb oldugunu tapin.

using System;
namespace Methods
{
    class Program
    {



        static void Main(string[] args)
        {
            Eded(1);





            static void Eded(int n)
            {
                int i = 0; for (i = 2; i <= n; i++)
                {
                    if (n % i == 0)
                    {
                        Console.Write("Murekkeb ededdir.");
                    }
                }
            }
            int i = 0; if (i == 0) { Console.Write("Sade ededdir."); }
            { }


        }

    }




}






