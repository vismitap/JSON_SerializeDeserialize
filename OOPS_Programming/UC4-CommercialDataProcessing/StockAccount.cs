using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace OOPS_Programming.UC4_CommercialDataProcessing
{
    internal class StockAccount
    {
        List<SharesModel> companySharesList = new List<SharesModel>();
        List<SharesModel> userSharesList = new List<SharesModel>();


        public void StockAccountCompanyRead(String filePath)
        {
            try
            {
                using (StreamReader reader = new StreamReader(filePath))
                {
                    var json = reader.ReadToEnd();
                    var itemsPresent = JsonConvert.DeserializeObject<List<SharesModel>>(json);
                    this.companySharesList = itemsPresent;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        public void StockAccountUserRead(String filePath)
        {
            try
            {
                using (StreamReader reader = new StreamReader(filePath))
                {
                    var json = reader.ReadToEnd();
                    var itemsPresent = JsonConvert.DeserializeObject<List<SharesModel>>(json);
                    this.userSharesList = itemsPresent;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        public void DisplayCompanyStock()
        {
            Console.WriteLine("Name\t\tNoOfShares\t\tPrice\t\tTransactionDateTime");
            foreach(var stock in this.companySharesList)
            {
                Console.WriteLine(stock.Name + "\t\t" + stock.NoOfShares + "\t\t" + stock.Price + "\t\t" + stock.TransactionDateTime);
            }
            Console.WriteLine();
        }
        public void DisplayUserStock()
        {
            Console.WriteLine("Name\t\tNoOfShares\t\tPrice\t\tTransactionDateTime");
            foreach (var stock in this.userSharesList)
            {
                Console.WriteLine(stock.Name +"\t\t"+ stock.NoOfShares + "\t\t"+ stock.Price + "\t\t" + stock.TransactionDateTime);
            }
            Console.WriteLine();
        }
    }
}
