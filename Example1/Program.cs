using System;

namespace Example1
{
    class Program
    {
        static void Main(string[] args)
        {
            Kayit kayit1 = new Kayit();

            Kayit kayit2 = new Kayit();


            Console.WriteLine("Adınızı gırınız");
            kayit1.Name = Console.ReadLine();

            Console.WriteLine("Soyadınızı gırınız");
            kayit1.Surnamme = Console.ReadLine();

            Console.WriteLine(" Yasınızı gırınız");
            kayit1.Age = Console.ReadLine();

            Console.WriteLine("Adınızı gırınız");
            kayit2.Name = Console.ReadLine();

            Console.WriteLine("Soyadınızı gırınız");
            kayit2.Surnamme = Console.ReadLine();

            Console.WriteLine(" Yasınızı gırınız");
            kayit2.Age = Console.ReadLine();

            Kayit[] kayitlar = new Kayit[] { kayit1, kayit2 };
            foreach (var kayit in kayitlar)
            {
                Console.WriteLine("ADI:" + kayit.Name + "Soyadı:" + kayit.Surnamme + "Yaş:" + kayit.Age);
            }


        }

        class Kayit
        {
            public string Name { get; set; }

            public string Surnamme { get; set; }

            public string Age { get; set; }
        }
    }
}
    

