using System;

namespace task_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 1. Verilmis n ededinin 3e ve 7 ye bolunub bolunmemesinin tapin.

            Bolunen(9);
            Bolunen(14);
            Bolunen(17);



        }

        static void Bolunen(int ededler)

        { int i = ededler;
            if (i % 3 == 0)
{ Console.WriteLine("3e bolunen"); }

            else if (i % 7 == 0)
            { Console.WriteLine("7ye bolunen"); }

            else
            { Console.WriteLine("Ne 3e nede 7ye bolunmur"); }
        }
    }
}
