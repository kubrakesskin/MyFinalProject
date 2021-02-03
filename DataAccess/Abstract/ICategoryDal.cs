using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Abstract
{
    public interface ICategoryDal : IEntityRepository<Category>
    {
        List<Category> GetAll(); //öncee dataacsess sağa tıkla project reference seç entities seç ok
        //ardından ampulden usingi seç 
        void Add(Category category);
        void Update(Category category);
        void Delete(Category category);
        List<Category> GetAllByCategory(int categoryId);//ürünleri kategoriye göre listele.
    }
}
