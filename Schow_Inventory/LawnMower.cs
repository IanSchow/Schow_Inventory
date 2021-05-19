using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Schow_Inventory
{
    class LawnMower : IShippable
    {
        decimal cost = 24.00M;
        string product = "Lawn Mower";

        public decimal ShipCost
        {
            get { return cost; }
        }
        public string Product
        {
            get { return product; }
        }
    }
}
