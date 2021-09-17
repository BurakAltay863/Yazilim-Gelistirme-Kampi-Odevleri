using GameProject.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject.Abstract
{
    interface ICampingService
    {

        void Add(Camping camping);
        void Update(Camping camping);
        void Delate(Camping camping);

    }
}
