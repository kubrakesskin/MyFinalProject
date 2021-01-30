using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IProductService
    {
        //iş katmanında kullanılır
        List<Product> GetAll();

        //business-add-project reference-dataacsess ve entity seç ardından ampulden using ekle

    }
}
