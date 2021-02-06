using Core.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace Core.DataAccess.EntityFramework
{
    public class EfEntityRepositoryBase<TEntity, TContext>:IEntityRepository<TEntity>
        //hemen public ekle ve tipleri belirt
        where TEntity: class, IEntity, new()
        where TContext : DbContext, new()
    
    {
        public void Add(TEntity entity)
        {
            using (TContext context = new TContext()) //us yazdıktan sonra usingi seç çift tab
            //using içinde yazılan nesne using bitince bellekten atılıt.
            {
                var addedEntity = context.Entry(entity); //veri kaynağından direkt ekler, ilişkilendirir.
                addedEntity.State = EntityState.Added;//durumu set et
                context.SaveChanges();//çalıştır

            }
        }

        public void Delete(TEntity entity)
        {
            using (TContext context = new TContext()) //us yazdıktan sonra usingi seç çift tab
            //veri tabanına gider hızlıca siler
            {
                var deletedEntity = context.Entry(entity); //veri kaynağından direkt ekler, ilişkilendirir.
                deletedEntity.State = EntityState.Deleted;//durumu set et
                context.SaveChanges();//çalıştır

            }
        }

        public TEntity Get(Expression<Func<TEntity, bool>> filter)
        {
            using (TContext context = new TContext())
            {
                return context.Set<TEntity>().SingleOrDefault(filter);
            }

        }

        public List<TEntity> GetAll(Expression<Func<TEntity, bool>> filter = null)
        {
            using (TContext context = new TContext())
            {
                return filter == null ? context.Set<TEntity>().ToList() : context.Set<TEntity>().Where(filter).ToList();
                //filtre null mı? evet ise tümünü getir 
                //değilse filtreleyip ver.
                //ampulden aç

            }
        }

        public void Update(TEntity entity)
        {
            using (TContext context = new TContext()) //us yazdıktan sonra usingi seç çift tab
            //veri tabanına gider hızlıca siler
            {
                var updatedEntity = context.Entry(entity); //veri kaynağından direkt ekler, ilişkilendirir.
                updatedEntity.State = EntityState.Modified;//durumu set et
                context.SaveChanges();//çalıştır

            }
        }
    }
}
