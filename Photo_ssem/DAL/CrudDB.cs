using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Reflection.Metadata.BlobBuilder;


namespace DAL
{
    public class CrudDB
    {

      public static void insertToDB(string name, string customerCode, int phone,string orderCode)
        {
            
            using (var context = new DbConnectionManagemen()) {
                Customers newCustomer=new Customers(name, customerCode, phone);
                OrderManagement newOrder=new OrderManagement(orderCode, 0, null, customerCode);

                try
                {
                    context.Add(newCustomer);
                    context.Add(newOrder);
                    context.SaveChanges();
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.ToString());
                }
       
            }
            

        }
    }
}
