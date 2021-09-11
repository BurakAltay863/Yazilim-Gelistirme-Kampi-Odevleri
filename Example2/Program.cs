using System;

namespace Example2
{
    class Program
    {
        static void Main(string[] args)
        {
            //1'den N kadar  3 e ve 7’ye tam bölünen sayılar

            for (int i = 1; i <= 1000; i++)
            {
                if (i % 3 == 0 && i % 7 == 0)
                {
                    Console.Write("  " + i);
                }
            }
            Console.ReadKey();
        }
    }
}
