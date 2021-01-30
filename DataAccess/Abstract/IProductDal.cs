using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Abstract
{
    public interface IProductDal //I VARSA PUBLİC UNUTMA :) 
    {
        List<Product> GetAll(); //öncee dataacsess sağa tıkla project reference seç entities seç ok
        //ardından ampulden usingi seç 
        void Add(Product product);
        void Update(Product product);
        void Delete(Product product);
        List<Product> GetAllByCategory(int categoryId);//ürünleri kategoriye göre listele.
    }
}
