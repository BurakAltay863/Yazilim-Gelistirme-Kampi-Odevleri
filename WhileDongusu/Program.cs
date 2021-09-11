using System;

namespace WhileDongusu
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = "";

            Console.WriteLine("isim giriniz");
            name = Console.ReadLine();

            while (name != "mehmet")
            {

                Console.WriteLine(" tekrar isim giriniz");
                name = Console.ReadLine();
                if (name == "mehmet")
                {
                    Console.WriteLine("basarı ıle tamamladınız");

                    break;
                }


            }
            Console.WriteLine("tebrıkler");
        }
    }
}
