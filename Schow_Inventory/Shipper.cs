using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Schow_Inventory
{
    class Shipper
    {
        int fillSize = 0;
        IShippable[] ProductArray = new IShippable[10];
        public void Add(IShippable product, int location)
        {
            ProductArray[location] = product;
            fillSize++;
        }

        public int GetProducts(string type)
        {
            int productNum = 0;
            for (int i = 0; i < fillSize; i++)
            {
                string arrType = ProductArray[i].Product;
                if (arrType == type)
                    productNum++;
            }
            return productNum;
        }

        public decimal GetTotal()
        {
            decimal total = 0;
            for (int i = 0; i < fillSize; i++)
            {
                decimal arrCost = ProductArray[i].ShipCost;
                total += arrCost;
            }
            return Math.Round(total, 3);
        }
    }
}
