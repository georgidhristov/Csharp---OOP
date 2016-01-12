using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Empires.Models.Recorces
{
    public class Steel : Resource
    {
        private const string steelType = "Steel";
        private const int steelQuantity = 10;

        public Steel() 
            : base(steelType, steelQuantity)
        {
        }
    }
}
