using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Schow_Inventory
{
    class Shipper
    {
        // Creating Variables
        int fillSize = 0;
        IShippable[] ProductArray = new IShippable[10];
        
        // Adding the newest product to the product array and increasing the counter keeping track of how full it is
        public void Add(IShippable product, int location)
        {
            ProductArray[location] = product;
            fillSize++;
        }

        // Counting how many of the chosen product is in the array
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

        // Adding up the total cost of everything i
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
