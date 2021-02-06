using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryProductDal : IProductDal //İMPLEMENTE ET
        //hata aldıgında tekrar ampulden implemente et
    //hemen PUBLIC YAZ, ampule tıkla Using ekle,tekrar ampule tıkla implement interface de.
    {
        //veri var gibi simüle edilir.
        List<ProductCategory> _products;
        //global değişken olduğu için _ kullandık.

        //ctor yaz + çift tab
        public InMemoryProductDal()
        {
            _products = new List<ProductCategory> { 
            //içinde ürün barındıran liste demek.

                new ProductCategory{ProductId=1 , CategoryId=1, ProductName="Bardak",UnitPrice=15, UnitsInStock=15},
                new ProductCategory{ProductId=2 , CategoryId=1, ProductName="Kamera",UnitPrice=500, UnitsInStock=3},
                new ProductCategory{ProductId=3 , CategoryId=2, ProductName="Telefon",UnitPrice=1500, UnitsInStock=2},
                new ProductCategory{ProductId=4 , CategoryId=2, ProductName="Klavye",UnitPrice=150, UnitsInStock=65},
                new ProductCategory{ProductId=5 , CategoryId=2, ProductName="Fare",UnitPrice=85, UnitsInStock=1},
            };
        }

        //burada beş adres verildi ve hepsi farklı referans numarasına sahiptir.

        public void Add(ProductCategory product)
        {
            _products.Add(product);
        }

        public void Delete(ProductCategory product)
        {

            //LINQ-Languge Integrated Query -> AYNI KODU BUNUNLA YAZALIM.
            ProductCategory productToDelete = _products.SingleOrDefault(p=>p.ProductId ==product.ProductId); //Lambda denilir.
            //ampulden system.linq seç
            //her p için gönderilen p'nin Id'si eşitse buna eşitle. 
            _products.Remove(productToDelete);
        }

        public List<ProductCategory> GetAll()
        {
            return _products; //veritabanını oldugu gibi döndür
        }

        

        public void Update(ProductCategory product)
        //VERİ KAYNAGINDAKİ REFERANSI BULUP GÜNCELLİYORUZ.
        {
            //Gönderdiğim ürün id'sine sahip olan listedeki ürünü bul
            ProductCategory productToUpdate = _products.SingleOrDefault(p => p.ProductId == product.ProductId); //Lambda denilir.
            productToUpdate.ProductName = product.ProductName;
            productToUpdate.CategoryId = product.CategoryId;
            productToUpdate.UnitPrice = product.UnitPrice;
            productToUpdate.UnitsInStock = product.UnitsInStock;

            //BUNU BİTİRDİĞİNDE IPRODUCTDAL'A GİT
        }

        public List<ProductCategory> GetAllByCategory(int categoryId)
        {
            return _products.Where(p => p.CategoryId == categoryId).ToList();
            //where içindeki şarta uyan elemanları yeni bir liste haline getirir ve onu döndürür.
            //business'a geç ve iş kurallarını yaz

        }

        public List<ProductCategory> GetAll(Expression<Func<ProductCategory, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public ProductCategory Get(Expression<Func<ProductCategory, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public List<ProductDetailDto> GetProductDetails()
        {
            throw new NotImplementedException();
        }
    } 
}
