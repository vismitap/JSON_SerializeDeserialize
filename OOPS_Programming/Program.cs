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
            InventoryManagement inventoryManagement = new InventoryManagement();
            inventoryManagement.ReadData(@"D:\Bridgelabz\Fellowship\VisualStudioProj\C#Progs\OOPS_Programming\Grocery.json");
        }
    }
}
