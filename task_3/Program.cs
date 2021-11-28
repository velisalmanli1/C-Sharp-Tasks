




//3)Verilmis n ve m (n<m) ededleri arasindaki tek ededlerin cemini tapin





using System;



namespace Methods

{

    class Program

    {









        static void Main(string[] args)



        {



            Cem(1, 9);













            static void Cem(int n, int m)



            {

                var sum = 0;





                for (int i = n; i <= m; i++)





                {

                    if (i % 2 == 1)



                        sum += i;









                    {

                    }







                }

                Console.WriteLine(sum);



            }











        }



    }



}







