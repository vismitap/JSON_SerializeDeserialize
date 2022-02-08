using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace OOPS_Programming.UC3_StockManagement
{
    internal class StockManagement
    {
        public void ReadData(String filePath)
        {
            try
            {
                using (StreamReader reader = new StreamReader(filePath))
                {
                    var json = reader.ReadToEnd();
                    var itemsPresent = JsonConvert.DeserializeObject<List<StockModel>>(json);
                    Console.WriteLine("Name\t\t" + "Price\t\t" + "NoOfShares\t" + "Total amount");
                    int totalValue = 0, amount =0;
                    foreach (var data in itemsPresent)
                    {
                        amount = data.Price * data.NoOfShares;
                        totalValue += amount;
                        Console.WriteLine(data.Name + "\t\t" + data.Price + "\t\t" + data.NoOfShares + "\t\t" + amount);
                    }
                    Console.WriteLine("\nTotal value is : Rs." + totalValue);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

    }
}
