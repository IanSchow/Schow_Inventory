using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Schow_Inventory
{
    class Crackers : IShippable 
    {
        decimal cost = 0.57M;
        string product = "Crackers";

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
