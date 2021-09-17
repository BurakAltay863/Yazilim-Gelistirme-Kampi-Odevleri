using GameProject.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject.Abstract
{
    interface ISaleService
    {
        public void Sale(Gamer gamer,Product product , Camping camping);
    }
}
