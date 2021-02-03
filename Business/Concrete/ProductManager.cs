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

        public List<Product> GetAllByCategoryId(int id)
        {
            return _productDal.GetAll(p=>p.CategoryId==id);
            //her p için benim gönderdiğim p eşitse onları filtrele

        }

        public List<Product> GetByUnitPrice(decimal min, decimal max)
        {
            return _productDal.GetAll(p => p.UnitPrice >= min && p.UnitPrice <= max);
            //iki fiyat aralığındaki datayı getirir

        }
    }
}
