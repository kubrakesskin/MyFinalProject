using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Concrete.EntityFramework
{
    //Context: Db tabloları ile proje classlarını bağlamak
    public class NorthwindContext: DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {//projenin ilişkili olduğu veritabanını belirtir.
            optionsBuilder.UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database=Northwind;Trusted_Connection=true"); 
            //sql server kullanacgız ve burada nasıl baglanacagımızı belirttik. swl ismimizi view menüsünden elde ettik

        }
        //prop çift tab
        public DbSet<ProductCategory> Products { get; set; } //product producta baglı
        public DbSet<Category> Categories { get; set; }
        public DbSet<Customer> Customers { get; set; }
        //artık ürün, kategori ve müşterilerle ilgili kodlarımızı yazabiliriz. (efproductdal'a gidebiliriz.)
        public DbSet<Order> Orders { get; set; }

    }

}
