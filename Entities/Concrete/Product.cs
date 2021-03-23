using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
    public  class Product
    {
        public string ProductName { get; set; }
        public int ProductId { get; set; }
        public int CategoryId { get; set; }
        public short UnıtsInStock { get; set; }
        public decimal UnıtPrice { get; set; }
    }
}
