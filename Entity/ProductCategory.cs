using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace practiceEntity.Entity
{
    public class ProductCategory
    {
        public Category Category { get; set; }
        public int CategoryId { get; set; }

        public Product Product { get; set; }
        public int ProductId { get; set; }
    }
}