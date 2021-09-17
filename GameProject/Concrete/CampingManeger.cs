using GameProject.Abstract;
using GameProject.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject.Concrete
{
    class CampingManeger : ICampingService
    {
       
        public void Add(Camping camping)
        {
            
            Console.WriteLine(camping.CampingName+"  Kampanyası " +
                camping.CampingProduct+" Ürünlerinde"+camping.Timeinterval+" Tarihleri arası"+camping.DiscountPrice+"%  indirme girmiştir");

        }

        public void Delate(Camping camping)
        {
            Console.WriteLine(camping.CampingName+" isimli kampanyanız bitmiştir");
        }

     

        public void Update(Camping camping)
        {
            Console.WriteLine(camping.CampingName + "  Kampanyası " +
               camping.CampingProduct + " Ürünlerinde" + camping.Timeinterval + " Tarihleri arası" + camping.DiscountPrice + "% +artı %25  indirme girmiştir");

        }
    }
}
