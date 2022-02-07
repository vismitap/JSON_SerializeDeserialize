using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace OOPS_Programming
{
    public class InventoryManagement
    {
        public void ReadData(String filePath)
        {
            try
            {
                using (StreamReader reader = new StreamReader(filePath))
                {
                    var json = reader.ReadToEnd();
                    var itemsPresent = JsonConvert.DeserializeObject<List<Inventory>>(json);
                    Console.WriteLine("Name\t" + "Price\t" + "Weight\t" + "Total amount");
                    foreach (var data in itemsPresent)

                    {
                        Console.WriteLine(data.Name + "\t" + data.Price + "\t" + data.Weight + "\t" + data.Price * data.Weight);
                    }
                }
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        internal void ReadData()
        {
            throw new NotImplementedException();
        }
    }
}
