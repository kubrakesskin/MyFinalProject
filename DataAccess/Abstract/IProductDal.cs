using Core.DataAccess;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Abstract
{
    public interface IProductDal:IEntityRepository<ProductCategory> //I VARSA PUBLİC UNUTMA :) 
    {
        List<ProductDetailDto> GetProductDetails(); //ürün detaylarını getir.

    }
}
//code refactoring:kodun iyileştirilmesi
