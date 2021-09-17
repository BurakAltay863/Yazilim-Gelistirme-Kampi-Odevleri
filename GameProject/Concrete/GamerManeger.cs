using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject
{
    //Micro Service
    class GamerManeger : IGamerService
    {
        IUserValadationService _userValadationService;

        public GamerManeger(IUserValadationService userValadationService)
        {
            _userValadationService = userValadationService;
        }

        public void Add(Gamer gamer)
        {

            {
                Console.WriteLine("Kayıt Basrılı"+gamer.FirstName+" "+gamer.LastName+" "+gamer.BirthYear+" "+gamer.Id+" "+gamer.IdentiyNumber);
            }
        }

        public void Delate(Gamer gamer)
        {
            Console.WriteLine("Kayıt silindi" + gamer.FirstName +  " " + gamer.LastName + " " + gamer.BirthYear + " " + gamer.Id + " " + gamer.IdentiyNumber);
        }

        public void Update(Gamer gamer)
        {
            Console.WriteLine("Kayıt güncellendi" + gamer.FirstName + " " + gamer.LastName + " " + gamer.BirthYear + " " + gamer.Id + " " + gamer.IdentiyNumber);
        }
    }
}
