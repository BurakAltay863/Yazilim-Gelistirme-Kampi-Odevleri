using GameProject.Abstract;
using GameProject.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject.Concrete
{
    class SaleManeger : ISaleService
    {
        public void Sale(Gamer gamer, Product product,Camping camping)
        {
            Console.WriteLine(gamer.FirstName+" Adlı oyuncu  "+product.GameName+"  isimli oyunu"
                +camping.CampingName+" Kampanya aracılgı ıle"
                +camping.DiscountPrice+"indirm ile" +product.UnityPrice + " Tl fiyata " 
                +product.Category+" adlı kategoriden satın almıstır");
        }

       
    }
}
