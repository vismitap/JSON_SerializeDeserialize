using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPS_Programming
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to OOPs problems!");
            bool flag = true;

            while (flag)
            {
                Console.WriteLine("\nEnter\n0 for Exit\n" +
                    "1 for UC1-InventoryManagement\n" +
                    "2 for UC2-InventoryManagementExtended\n" +
                    "3 for UC3-StockManagement\n" +
                    "4 for UC4-StockManagement\n");

                Console.WriteLine("Enter the option:");
                int option = Convert.ToInt32(Console.ReadLine());

                switch (option)
                {
                    case 0: 
                        flag = false;
                        break;

                    case 1:
                        InventoryManagement inventoryManagement = new InventoryManagement();
                        inventoryManagement.ReadData(@"D:\Bridgelabz\Fellowship\VisualStudioProj\C#Progs\OOPs\OOPS_Programming\UC1-InventoryManagementJSON\Grocery.json");
                        break;

                    case 2:
                        UC2_InventoryManagementExtended.InventoryManagementExtended inventory = new UC2_InventoryManagementExtended.InventoryManagementExtended();
                        inventory.ReadData(@"D:\Bridgelabz\Fellowship\VisualStudioProj\C#Progs\OOPs\OOPS_Programming\UC2-InventoryManagementExtended\GroceryItems.json");
                        inventory.Display();
                        inventory.WriteData(@"D:\Bridgelabz\Fellowship\VisualStudioProj\C#Progs\OOPs\OOPS_Programming\UC2-InventoryManagementExtended\GroceryItems.json");
                        break;

                    case 3:
                        UC3_StockManagement.StockManagement stock = new UC3_StockManagement.StockManagement();
                        stock.ReadData(@"D:\Bridgelabz\Fellowship\VisualStudioProj\C#Progs\OOPs\OOPS_Programming\UC3-StockManagement\Stocks.json");
                        break;

                    case 4:
                        UC4_CommercialDataProcessing.StockAccount stockAccount = new UC4_CommercialDataProcessing.StockAccount();
                        stockAccount.StockAccountCompanyRead(@"D:\Bridgelabz\Fellowship\VisualStudioProj\C#Progs\OOPs\OOPS_Programming\UC4-CommercialDataProcessing\CompanyShares.json");
                        stockAccount.StockAccountUserRead(@"D:\Bridgelabz\Fellowship\VisualStudioProj\C#Progs\OOPs\OOPS_Programming\UC4-CommercialDataProcessing\CustomerShares.json");
                        stockAccount.DisplayCompanyStock();
                        stockAccount.DisplayUserStock();
                        break;
                }

            }
        }
    }
}
