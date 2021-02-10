using Business.Abstract;
using Business.Constants;
using Core.Utilities.Results;
using DataAccess.Abstract;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;
using Entities.DTOs;
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

        public IResult Add(Product product) //void oldugu icin özel tip döndürmez
        {
            //business codes
            if (product.ProductName.Length < 2)
            {
                //magic strings:stringleri ayrı ayrı yazmak.
                //her yerde tekrarlarsan degistirmek istediginde sorun yasarsın.

                return new ErrorResult(Messages.ProductNameInvalid);

            }
            _productDal.Add(product);
            return new SuccessResult(Messages.ProductAdded);
        }

        //ampulden using
        public IDataResult<List<Product>> GetAll()
        {
            if (DateTime.Now.Hour == 22)
            {
                return new ErrorDataResult<List<Product>>(Messages.MaintenanceTime);
           //ampulden generate field
            }
            //iş kodları
            //yetkisi var mı?
            return new SuccessDataResult<List<Product>>(_productDal.GetAll(), Messages.ProductsListed); //bu imzadır.
           //ampulden generate field
        }

        public IDataResult<List<Product>> GetAllByCategoryId(int id)
        {
            return new SuccessDataResult<List<Product>>(_productDal.GetAll(p=>p.CategoryId==id));
            //her p için benim gönderdiğim p eşitse onları filtrele

        }

        public IDataResult<List<Product>> GetByUnitPrice(decimal min, decimal max)
        {
            return new SuccessDataResult<List<Product>>(_productDal.GetAll(p => p.UnitPrice >= min && p.UnitPrice <= max));
            //iki fiyat aralığındaki datayı getirir

        }

        public IDataResult<Product> GetByID(int productId)
        {
            return new SuccessDataResult<Product>(_productDal.Get(p =>p.ProductId == productId));
        }

        public SuccessDataResult<List<ProductDetailDto>> GetProductDetails()
        {
            return new SuccessDataResult<List<ProductDetailDto>>(_productDal.GetProductDetails());
        }

        IDataResult<List<ProductDetailDto>> IProductService.GetProductDetails()
        {
            throw new NotImplementedException();
        }

        public IDataResult<Product> GetById(int productId)
        {
            throw new NotImplementedException();
        }
    }
}
