using System;

namespace SwitchCaseYapısı
{
    class Program
    {
        static void Main(string[] args)
        {

            switch (DateTime.Now.DayOfWeek)
            {
                case DayOfWeek.Saturday:
                case DayOfWeek.Sunday:
                    Console.WriteLine("Dinlen şimdi pazartesi iş bizi bekler...");
                    break;
                default:
                    Console.WriteLine("Haftaiçindeyiz çalışmaya devam...");
                    break;
            }
        }
    }
}
