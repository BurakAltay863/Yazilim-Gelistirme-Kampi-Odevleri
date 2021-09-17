using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject
{
    class UserValidationManeger : IUserValadationService
    {
        public bool Validate(Gamer gamer)
        {
            if (gamer.BirthYear == 2000 && gamer.FirstName == "ENGİN" &&
                gamer.LastName == "DEMİROĞ" && gamer.IdentiyNumber == 12345)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
