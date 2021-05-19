using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Schow_Inventory
{
    class BaseballGlove : IShippable 
    {
        decimal cost = 3.23M;
        string product = "Baseball Glove";

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
