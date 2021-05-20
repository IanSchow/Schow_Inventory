using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Schow_Inventory
{
    interface IShippable
    {
        // Getting the product cost
        decimal ShipCost { get; }
        // Getting the product type
        string Product { get; }
    }
}
