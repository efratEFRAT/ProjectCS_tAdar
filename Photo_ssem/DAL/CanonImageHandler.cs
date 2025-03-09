using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public  class CanonImageHandler
    {
        public static List<string> readFromFile(string path)
        {
            List<string> imges = new List<string>();
            foreach (string s in File.ReadLines(path))
            {
                if (s.Contains("SRC"))
                {
                    int index = s.IndexOf("..");
                    if (index != 0)
                    {
                        string record = s.Substring(index + 1).TrimEnd('"', '>');
                        record = record.Replace('/', '\\');
                        imges.Add(record);
                    }
                }


            }
            return imges;
        }
        public static void insertImgToDB(string path, string orderCode,string size)
        {
            List<string> imges = readFromFile(path);
            using (var context = new DbConnectionManagemen())
            {
                foreach (string s in imges)
                {
                    byte[] byteArray = Encoding.UTF8.GetBytes(s);
                    SavingImages newSavingImages =new SavingImages(orderCode, byteArray, 0, size);
                    try
                    {
                        context.Add(newSavingImages);
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
}
