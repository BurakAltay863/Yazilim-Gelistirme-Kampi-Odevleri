using System;

namespace MyList
{
    class Program
    {
        static void Main(string[] args)
        {

            MyDictionary<int, string> isimler = new MyDictionary<int, string>();
            isimler.Add(12, "Burak");
            isimler.Add(15, "ali");
            isimler.Add(13, "Altay");


            Console.WriteLine(isimler.Count);
            Console.WriteLine(isimler.Count1);
        }
    }
}
