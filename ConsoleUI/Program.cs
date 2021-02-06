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
        //ProductTest();
        static void Main(string[] args)
        {
            //CategoryTest();
            ProductTest();
        }

        private static void CategoryTest()
        {
            CategoryManager categoryManager = new CategoryManager(new EfCategoryDal());
            foreach (var category in categoryManager.GetAll())
            {
                Console.WriteLine(category.CategoryName);
            }
        }

        private static void ProductTest()
        {
            ProductManager productManager = new ProductManager(new EfProductDal());//cümle bittiğinde çözdür

            //ConsoleUI-add-p.referance-üçünü de seç
            //ardından ampulden çözdür.
            foreach (var product in productManager.GetProductDetails())
            {
                Console.WriteLine(product.ProductName + "/" + product.CategoryName);
            }
            //consoleUı SET AS START UP PROJECT DİYEREK BAŞLAT.
            //ÜRÜNLER LİSTELENDİ :)
        }
    }
}
