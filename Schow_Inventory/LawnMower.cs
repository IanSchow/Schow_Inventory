using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Schow_Inventory
{
    class LawnMower : IShippable
    {
        // Creating vars
        decimal cost = 24.00M;
        string product = "Lawn Mower";

        // Returning Lawn Mower Cost
        public decimal ShipCost
        {
            get { return cost; }
        }

        // Returning Lawn Mower Type
        public string Product
        {
            get { return product; }
        }
    }
}
