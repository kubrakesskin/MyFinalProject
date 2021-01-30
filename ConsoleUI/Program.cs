using Business.Concrete;
using DataAccess.Concrete.InMemory;
using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            ProductManager productManager = new ProductManager(new InMemoryProductDal());//cümle bittiğinde çözdür

            //ConsoleUI-add-p.referance-üçünü de seç
            //ardından ampulden çözdür.
            foreach (var product in productManager.GetAll())
            {
                Console.WriteLine(product.ProductName);
            }
           //consoleUı SET AS START UP PROJECT DİYEREK BAŞLAT.
           //ÜRÜNLER LİSTELENDİ :)
        }
    }
}
