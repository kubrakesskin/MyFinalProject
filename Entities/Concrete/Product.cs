//using Entities.Abstract;
using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
    public class Product:IEntity
        //ampulden usingi seç
    {
        public int ProductId { get; set; }
        public int CategoryId { get; set; }
        public string ProductName { get; set; }
        public short UnitsInStock { get; set; } //int'in bir küçüğü
        public decimal UnitPrice { get; set; }
    }
}
