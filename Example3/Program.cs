using System;

namespace Example3
{
    class Program
    {
        static void Main(string[] args)
        {
            Teknoloji urun1 = new Teknoloji();
            Teknoloji urun2 = new Teknoloji();
            Teknoloji urun3 = new Teknoloji();
            urun1.UrunAdi = "monster gaming pc";
            urun1.UretimYerı = "Turkey";
            urun1.UrunFiyat = 7000;
            urun1.UretimTarihi = 2016;

            urun2.UrunAdi = "Asus gaming pc";
            urun2.UretimYerı = "Almanya";
            urun2.UrunFiyat = 6000;
            urun2.UretimTarihi = 2019;


            urun3.UrunAdi = "excalibur gaming pc";
            urun3.UretimYerı = "England";
            urun3.UrunFiyat = 7500;
            urun3.UretimTarihi = 2020;

            Teknoloji[] urunler = new Teknoloji[] { urun1, urun2, urun3 };
            Console.WriteLine("foreach");
            foreach (var teknoloji in urunler)
            {
                Console.WriteLine("Urun adi:" + teknoloji.UrunAdi + "UretımYeri:" + teknoloji.UretimYerı +
                    "UrunFıyat:" + teknoloji.UrunFiyat + "UretımTarıhı:" + teknoloji.UretimTarihi);
            }
            Console.WriteLine("for dongusuuu");

            for (int i = 0; i < urunler.Length; i++)
            {
                Console.WriteLine("Urun adı:" + urunler[i].UrunAdi + "uretım yeri" + urunler[i].UretimYerı + "urun fıyat:" +
                    urunler[i].UrunFiyat + "urun tarıhı:" + urunler[i].UretimTarihi);
            }
            Console.WriteLine("while dongusu ile");
            int x = 0;
            while (x < urunler.Length)
            {
                Console.WriteLine("Urun adı:" + urunler[x].UrunAdi + "uretım yeri" + urunler[x].UretimYerı + "urun fıyat:" +
                    urunler[x].UrunFiyat + "urun tarıhı:" + urunler[x].UretimTarihi);
                x = x + 1;
            }
        }

        class Teknoloji
        {

            public string UrunAdi { get; set; }

            public string UretimYerı { get; set; }

            public int UretimTarihi { get; set; }


            public int UrunFiyat { get; set; }
        }
    }
  }

