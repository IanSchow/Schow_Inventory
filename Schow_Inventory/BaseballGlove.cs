using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Schow_Inventory
{
    class BaseballGlove : IShippable 
    {
        // Creating vars
        decimal cost = 3.23M;
        string product = "Baseball Glove";

        // Returning Baseball Glove cost
        public decimal ShipCost
        {
            get { return cost; }
        }

        // Returning Baseball Glove type
        public string Product
        {
            get { return product; }
        }
    }
}
