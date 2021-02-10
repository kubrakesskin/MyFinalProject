using Core.Utilities.Results;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IProductService
    {
        //iş katmanında kullanılır
        IDataResult<List<Product>> GetAll(); //tümünü getir
        //list ptoduct kısmı verdiğimiz t'dir.
        IDataResult<List<Product>> GetAllByCategoryId(int id);
        //kategori idsine göre getir.

        //business-add-project reference-dataacsess ve entity seç ardından ampulden using ekle
        IDataResult<List<Product>> GetByUnitPrice(decimal min, decimal max);
        //şu fiyat aralığındaki ürünleri getir.
        IDataResult<List<ProductDetailDto>> GetProductDetails();
        IDataResult<Product> GetById(int productId); //tek balına ürün döndürür(beden gibi)
        IResult Add(Product product); 
    }
}
