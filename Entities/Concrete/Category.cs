using Core.Entities;
//using Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
    //Çıplak Class Kalmasın. Yani işaretleme, gruplama tercih et

    public class Category:IEntity
        //ampulden usingi seçmelisin yoksa hata verir.
    {
        public int CategoryId { get; set; }
        public string CategoryName { get; set; }
    }
}
