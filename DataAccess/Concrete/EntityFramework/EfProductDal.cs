using DataAccess.Abstract;
using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete.EntityFramework
{
    //NuGet: başkalarının yazdığı kodları( paketleri ) kullanmak için

    public class EfProductDal : IProductDal
        //iki defa ampulden seç
    {
        public void Add(Product entity)
        {
            using (NorthwindContext context=new NorthwindContext()) //us yazdıktan sonra usingi seç çift tab
            //using içinde yazılan nesne using bitince bellekten atılıt.
            {
                var addedEntity = context.Entry(entity); //veri kaynağından direkt ekler, ilişkilendirir.
                addedEntity.State = EntityState.Added;//durumu set et
                context.SaveChanges();//çalıştır

            }
        }

        public void Delete(Product entity)
        {
            using (NorthwindContext context = new NorthwindContext()) //us yazdıktan sonra usingi seç çift tab
            //veri tabanına gider hızlıca siler
            {
                var deletedEntity = context.Entry(entity); //veri kaynağından direkt ekler, ilişkilendirir.
                deletedEntity.State = EntityState.Deleted;//durumu set et
                context.SaveChanges();//çalıştır

            }
        }

        public Product Get(Expression<Func<Product, bool>> filter)
        {
            using (NorthwindContext context = new NorthwindContext())
            {
                return context.Set<Product>().SingleOrDefault(filter);
            }
            
        }

        public List<Product> GetAll(Expression<Func<Product, bool>> filter = null)
        {
            using (NorthwindContext context = new NorthwindContext())
            {
                return filter == null ? context.Set<Product>().ToList() : context.Set<Product>().Where(filter).ToList();
                    //filtre null mı? evet ise tümünü getir 
                    //değilse filtreleyip ver.
                    //ampulden aç
                    
            }
        }

        public void Update(Product entity)
        {
            using (NorthwindContext context = new NorthwindContext()) //us yazdıktan sonra usingi seç çift tab
            //veri tabanına gider hızlıca siler
            {
                var updatedEntity = context.Entry(entity); //veri kaynağından direkt ekler, ilişkilendirir.
                updatedEntity.State = EntityState.Modified;//durumu set et
                context.SaveChanges();//çalıştır

            }
        }
    }
}
