//using gereksiz oldugu icin sildik
using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace Core.DataAccess //namespace isim uzayıdır.
{
    //generic constraint: kısıtlama için kullanılır. Where: şeklinde yazılır
    public interface IEntityRepository<T> where T:class, IEntity, new() 
        //WHERE İLE ÇALIŞACAGIMIZ TİPİ SÖYLER.
    {   //class: referans tiptir...
        //new: newwlenebilir olmalı
        //IEntity : IEntity olabilir veya IEntity'i implemente eden bir nesne olabilir.

        List<T> GetAll(Expression<Func<T,bool>> filter=null); //öncee dataacsess sağa tıkla project reference seç entities seç ok
        //ardından ampulden usingi ve sonra system'ı seç 
        //expression methodu ile ayrı ayrı yazmayız, detaya tek adımda gidebiliriz
        //filtre vermezse tüm datayı ister. 

        T Get(Expression<Func<T, bool>> filter);
        void Add(T entity);
        void Update(T entity);
        void Delete(T entity);
    }
}
