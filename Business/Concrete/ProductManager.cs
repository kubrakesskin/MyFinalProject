using Business.Abstract;
using DataAccess.Abstract;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class ProductManager : IProductService
        //ampulden önce çöz sonra implemente et.
    {
        IProductDal _productDal;
        //önce ampulden çöz
        //sonra ampulden generitace ekle

        public ProductManager(IProductDal productDal)
        {
            _productDal = productDal;
        }

        //ampulden using
        public List<Product> GetAll()
        {
            //iş kodları
            //yetkisi var mı?
            return _productDal.GetAll(); //bu imzadır.
           
        }
    }
}
