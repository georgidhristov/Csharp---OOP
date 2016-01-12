using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Empires.Models.Recorces
{
    public class Gold : Resource
    {
        private const string goldType = "Gold";
        private const int goldQuantity = 5;

        public Gold()
            : base(goldType, goldQuantity)
        {
        }
    }
}
