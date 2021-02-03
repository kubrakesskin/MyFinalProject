using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IProductService
    {
        //iş katmanında kullanılır
        List<Product> GetAll(); //tümünü getir
        List<Product> GetAllByCategoryId(int id);
        //kategori idsine göre getir.

        //business-add-project reference-dataacsess ve entity seç ardından ampulden using ekle
        List<Product> GetByUnitPrice(decimal min, decimal max);
        //şu fiyat aralığındaki ürünleri getir.
    }
}
