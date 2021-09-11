using System;

namespace TernaryOperator
{
    class Program
    {
        static void Main(string[] args)
        {
            //Ternary Operatörü
            //koşul ? doğru ise burası : yanlış ise burası çalışsın
            Console.Write("[1-10] arasında sayı giriniz :");
            int sayi = int.Parse(Console.ReadLine());
            string cevap = "";
            cevap = sayi == 7 ? "Tebrikler doğru bildiniz" : "Yanlış cevap";
            Console.WriteLine(cevap);


            Console.WriteLine("rastgele bir isim giriniz");
            string name = Console.ReadLine();
            string ad = "";

            ad = name == "BURAK" ? "cok sanslısınız" : "uzulme tekrar dene";
            Console.WriteLine(ad);
        }
    }
}
