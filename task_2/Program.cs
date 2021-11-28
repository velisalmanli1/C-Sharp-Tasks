using System;

namespace task_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 2. Verilmis n ve m (n<m) edeleri arasindaki tek ededlerin sayini tapin.

            Say(5, 15);



            static void Say(int n, int m)

            {

                for (int i =n; i < m; i++)


                { if (i%2==1)
                        Console.WriteLine(i);}
            }
        }
    }
}
