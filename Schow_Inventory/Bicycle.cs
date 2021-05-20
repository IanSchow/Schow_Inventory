using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Schow_Inventory
{
    class Bicycle : IShippable
    {
        // Creating vars
        decimal cost = 9.50M;
        string product = "Bicycle";

        // Returning Bike Cost
        public decimal ShipCost
        {
            get { return cost; }
        }

        // Returning Bike Type
        public string Product
        {
            get { return product; }
        }

    }
}
