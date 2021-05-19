using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Schow_Inventory
{
    class Bicycle : IShippable
    {
        decimal cost = 9.50M;
        string product = "Bicycle";

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
