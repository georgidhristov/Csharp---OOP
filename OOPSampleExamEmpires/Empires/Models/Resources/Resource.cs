using Empires.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Empires.Models.Recorces
{
    public class Resource : IResources
    {
        private string resourceType;
        private int quantity;

        public Resource(string resourceType, int quantity) 
        {
            this.resourceType = ResourceType;
            this.quantity = Quantity;
        }

        public string ResourceType
        {
            get { return resourceType; }
        }

        public int Quantity
        {
            get { return quantity; }
        }
    }
}
