using Empires.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Empires.Models.Buildings
{
    public class Building : IBuilding
    {
        public virtual IUnit CreateUnit()
        {
            throw new NotImplementedException("Goshe v Building classa e problema!");
        }

        public virtual IResources CreateResource()
        {
            throw new NotImplementedException("Goshe v Building classa e problema!");
        }
    }
}
