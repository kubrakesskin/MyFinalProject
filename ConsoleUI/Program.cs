using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;
using System;

namespace ConsoleUI
{
    //SOLİD KAVRAMININ O HARFİNE KARŞILIK GELİR :) YANİ OPEN CLOSED PRİNCİPLE
    //YAPTIĞIN YAZILAMA YENİ ÖZELLİK EKLİYORSAN MEVCUT KODA DOKUNAMAZSIN

    class Program
    {
        static void Main(string[] args)
        {
            ProductManager productManager = new ProductManager(new EfProductDal());//cümle bittiğinde çözdür

            //ConsoleUI-add-p.referance-üçünü de seç
            //ardından ampulden çözdür.
            foreach (var product in productManager.GetByUnitPrice(50,100))
            {
                Console.WriteLine(product.ProductName);
            }
           //consoleUı SET AS START UP PROJECT DİYEREK BAŞLAT.
           //ÜRÜNLER LİSTELENDİ :)
        }
    }
}
