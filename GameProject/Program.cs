using GameProject.Concrete;
using GameProject.Abstract;
using GameProject.Entities;
using System;

namespace GameProject
{
    class Program
    {
        static void Main(string[] args)
        {
            SaleManeger saleManeger = new SaleManeger();
            CampingManeger campingManeger = new CampingManeger();
            GamerManeger gamerManeger = new GamerManeger(new UserValidationManeger());
            
            Gamer gamer1 = new Gamer();
            gamer1.Id = 12;
            gamer1.BirthYear = 2001;
            gamer1.IdentiyNumber = 555;
            gamer1.FirstName = "Burak";
            gamer1.LastName = "Altay";

            Gamer gamer2 = new Gamer();
            gamer2.Id = 123;
            gamer2.BirthYear = 2002;
            gamer2.IdentiyNumber = 556;
            gamer2.FirstName = "Ali";
            gamer2.LastName = "Sevim";

            Gamer gamer3 = new Gamer();
            gamer3.Id = 15;
            gamer3.BirthYear = 2003;
            gamer3.IdentiyNumber = 855;
            gamer3.FirstName = "Tayfun";
            gamer3.LastName = "Katılmıs";

            Product product1 = new Product();
            product1.Category = "battle";
            product1.GameName = "Valorant";
            product1.UnityPrice = 20;

            Product product2 = new Product();
            product2.Category = "battle";
            product2.GameName = "Pugb";
            product2.UnityPrice = 25;

            Camping camping1 = new Camping();
            camping1.CampingName = "Savaş oyunları ındırımları";
            camping1.CampingProduct = "Şavaş oyunları";
            camping1.DiscountPrice = 25;
            camping1.Timeinterval = "15-20 nisan arası";

            Camping camping2 = new Camping();
            camping2.CampingName = "Stratejı oyunları ındırımları";
            camping2.CampingProduct = "Strateji oyunları";
            camping2.DiscountPrice = 30;
            camping2.Timeinterval = "15-20 agustos arası";

            gamerManeger.Add(gamer1);
            gamerManeger.Delate(gamer2);
            gamerManeger.Update(gamer3);

            campingManeger.Add(camping1);
            campingManeger.Add(camping2);
            campingManeger.Delate(camping2);
            campingManeger.Update(camping1);

            saleManeger.Sale(gamer3,product1,camping1);


        }
    }
}
