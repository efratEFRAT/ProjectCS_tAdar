
using System.Numerics;
using DAL;
using BLL;

namespace BLL
{
    public class Class1
    {
        //חילול פונקציה יוניקית:)
        public static string GenerateShortUniqueCodeFromGuid()
        {
            string guid = Guid.NewGuid().ToString().Replace("-", "");
            return guid.Substring(0, 8); // קיצור ל-8 תווים

        }

        public static void ReadImage()
        {
            

        }

        public static void newOrder(string name, string customerCode, int phone, string orderCode,string path)
        {
            DAL.CrudDB.insertToDB(name, customerCode, phone, orderCode);
            //DAL.CanonImageHandler.insertImgToDB(path,orderCode);
        }
        public static void newSavaimg(string path, string orderCode, string size)
        {
            
            DAL.CanonImageHandler.insertImgToDB(path, orderCode,size);
        }
    }
}


