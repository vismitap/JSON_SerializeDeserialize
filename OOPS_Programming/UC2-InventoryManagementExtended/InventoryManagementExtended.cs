using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace OOPS_Programming.UC2_InventoryManagementExtended
{
    internal class InventoryManagementExtended
    {
        List<Inventory> riceList = new List<Inventory>();
        List<Inventory> wheatList = new List<Inventory>();
        List<Inventory> pulseList = new List<Inventory>();


        public void ReadData(String filePath)
        {
            try
            {
                using (StreamReader reader = new StreamReader(filePath))
                {
                    var json = reader.ReadToEnd();
                    var itemsPresent = JsonConvert.DeserializeObject<InventoryFactory>(json);
                    this.riceList = itemsPresent.RiceList;
                    this.wheatList = itemsPresent.WheatList;
                    this.pulseList = itemsPresent.PulsesList;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        public void Display()
        {
            if (this.riceList != null)
            {
                Console.WriteLine("\n*******RiceList******\n");
                Console.WriteLine("Name\t\tPrice\t\tWeight");

                foreach (var item in this.riceList)
                {
                    Console.WriteLine(item.Name+ "\t\t" + item.Price + "\t\t" + item.Weight);
                }
            }

            if(this.wheatList != null)
            {
                Console.WriteLine("\n*******WheatList******\n");
                Console.WriteLine("Name\t\tPrice\t\tWeight");

                foreach (var item in this.wheatList)
                {
                    Console.WriteLine(item.Name + "\t\t" + item.Price + "\t\t" + item.Weight);
                }
            }

            if (this.pulseList != null)
            {
                Console.WriteLine("\n*******PulsesList******\n");
                Console.WriteLine("Name\t\tPrice\t\tWeight");

                foreach (var item in this.pulseList)
                {
                    Console.WriteLine(item.Name + "\t\t" + item.Price + "\t\t" + item.Weight);
                }
            }
        }

        public bool IsDuplicate(List<Inventory> inventory, string name)
        {
            foreach(var data in inventory)
            {
                if(data.Name == name)
                {
                    return true;
                }
            }
            return false;
        }
        public void WriteData(string filePath)
        {
            try
            { 
                Console.WriteLine("\nEnter the option: Enter\n1 for Rice\n2 for Wheat\n3 for Pulses");
                int option = Convert.ToInt32(Console.ReadLine());
                Inventory inventory = new Inventory();
                switch (option)
                {
                    case 1:
                        inventory.Name = "Abc";
                        inventory.Price = 20;
                        inventory.Weight = 30;
                        if(!IsDuplicate(this.riceList, inventory.Name))
                        {
                             this.riceList.Add(inventory);
                        }
                        else
                        {
                            Console.WriteLine("The added item already exists!");
                        }
                        break;

                    case 2:
                        inventory.Name = "xyz";
                        inventory.Price = 20;
                        inventory.Weight = 30;
                        if (!IsDuplicate(this.wheatList, inventory.Name))
                        {
                            this.wheatList.Add(inventory);
                        }
                        else
                        {
                            Console.WriteLine("The added item already exists!");
                        }
                        break;

                    case 3:
                        inventory.Name = "def";
                        inventory.Price = 23;
                        inventory.Weight = 35;
                        if (!IsDuplicate(this.pulseList, inventory.Name))
                        {
                            this.pulseList.Add(inventory);
                        }
                        else
                        {
                            Console.WriteLine("The added item already exists!");
                        }
                        break;
                }

                InventoryFactory inventoryFactory = new InventoryFactory();
                inventoryFactory.RiceList = this.riceList;
                inventoryFactory.WheatList = this.wheatList;
                inventoryFactory.PulsesList = this.pulseList;

                var jsonData = JsonConvert.SerializeObject(inventoryFactory);
                File.WriteAllText(filePath, jsonData);

                ReadData(filePath);
                Display();

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
