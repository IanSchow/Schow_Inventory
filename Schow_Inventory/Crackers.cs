using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Schow_Inventory
{
    class Crackers : IShippable 
    {
        // Creating vars
        decimal cost = 0.57M;
        string product = "Crackers";

        // Returning Crackers cost

        public decimal ShipCost
        {
            get { return cost; }
        }

        // Returning Crackers type
        public string Product
        {
            get { return product; }
        }
    }
}
