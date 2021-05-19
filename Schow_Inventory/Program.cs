using System;

namespace Schow_Inventory
{
    class Program
    {
        static void Main(string[] args)
        {
            Shipper PostMaster = new Shipper();
            bool compute = false;
            int i = 0;
            
            do
            {
                int selection = 0;
                bool successful = false;
                do
                {
                    if (i > 10)
                        break;
                    else if (i < 10)
                    {
                        Console.WriteLine("Choose from the following options:");
                        Console.WriteLine("1. Add a Bicycle to the Shipment");
                        Console.WriteLine("2. Add a Lawn Mower to the Shipment");
                        Console.WriteLine("3. Add a Baseball Glove to the shipment");
                        Console.WriteLine("4. Add Crackers to the shipment");
                        Console.WriteLine("5. List Shipment Items");
                        Console.WriteLine("6. Compute Shipping Charges");

                        string response = Console.ReadLine();
                        successful = int.TryParse(response, out selection);
                        if (!successful || selection > 6 || selection <= 0)
                        {
                            Console.Clear();
                            Console.WriteLine("Invalid input, please try again.");
                            Console.WriteLine();
                        }
                    }
                    else if (i == 10)
                    {
                        Console.WriteLine("Max Number of Products Reached. Choose one of the following:");
                        Console.WriteLine("1. List Shipment Items");
                        Console.WriteLine("2. Compute Shipping Charges");

                        string response = Console.ReadLine();
                        successful = int.TryParse(response, out selection);
                        if (!successful || selection > 6 || selection <= 0)
                        {
                            Console.Clear();
                            Console.WriteLine("Invalid input, please try again.");
                            Console.WriteLine();
                        }
                        else if (successful && selection == 1)
                            selection = 5;
                        else if (successful && selection == 2)
                            selection = 6;
                    }
                } while (successful == false);
                
                if (selection == 1 && i <= 10)
                {
                    IShippable bike = new Bicycle();
                    PostMaster.Add(bike, i);
                    i++;
                    Console.Clear();
                    Console.WriteLine("1 Bicycle has been added");
                    Console.WriteLine();
                }
                else if (selection == 2 && i <= 10)
                {
                    IShippable mower = new LawnMower();
                    PostMaster.Add(mower, i);
                    i++;
                    Console.Clear();
                    Console.WriteLine("1 Lawn Mower has been added");
                    Console.WriteLine();
                }
                else if (selection == 3 && i <= 10)
                {IShippable bball = new BaseballGlove();
                    PostMaster.Add(bball, i);
                    i++;
                    Console.Clear();
                    Console.WriteLine("1 Baseball Glove has been added");
                    Console.WriteLine();
                }
                else if (selection == 4 && i <= 10)
                {
                    IShippable ritz = new Crackers();
                    PostMaster.Add(ritz, i);
                    i++;
                    Console.Clear();
                    Console.WriteLine("1 Box of Crackers has been added");
                    Console.WriteLine();
                }
                else if (selection == 5 && i <= 10)
                {
                    int bikeNum = PostMaster.GetProducts("Bicycle");
                    int mowNum = PostMaster.GetProducts("Lawn Mower");
                    int bballNum = PostMaster.GetProducts("Baseball Glove");
                    int crackNum = PostMaster.GetProducts("Crackers");

                    Console.Clear();
                    if (bikeNum + mowNum + bballNum + crackNum >= 1)
                        Console.WriteLine("Shipment Manifest:");
                    else
                        Console.WriteLine("No Products Added");

                    if (bikeNum == 1)
                        Console.WriteLine(bikeNum + " Bicycle");
                    else if (bikeNum > 1)
                        Console.WriteLine(bikeNum + " Bicycles");
                    
                    if (mowNum == 1)
                        Console.WriteLine(mowNum + " Lawn Mower");
                    else if (mowNum > 1)
                        Console.WriteLine(mowNum + " Lawn Mowers");

                    if (bballNum == 1)
                        Console.WriteLine(bballNum + " Baseball Glove");
                    else if (bballNum > 1)
                        Console.WriteLine(bballNum + " Baseball Gloves");

                    if (crackNum > 0)
                        Console.WriteLine(crackNum + " Crackers");
                    Console.WriteLine();
                }
                else if (selection == 6 || i > 10)
                {
                    decimal totalCost = PostMaster.GetTotal();
                    Console.Clear();
                    Console.WriteLine(String.Format("Total shipping cost for this order is {0:C2}", totalCost));
                    compute = true;
                } 
            } while (compute == false);
        }
    }
}
