using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft;
using Microsoft.EntityFrameworkCore;
using static System.Reflection.Metadata.BlobBuilder;


namespace DAL
{
    public class DbConnectionManagemen : DbContext
    {
        public DbSet<Customers> Customers { get; set; }
        public DbSet<Officer> Officer { get; set; }
        public DbSet<OrderManagement> OrderManagement { get; set; }
        public DbSet<SavingImages> SavingImages { get; set; }
        public DbSet<Statuses> Statuses { get; set; }
      
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server = SQLSRV;DataBase = ssem_Photo;Trusted_Connection=True;Encrypt = False;");
        }

    }
}
