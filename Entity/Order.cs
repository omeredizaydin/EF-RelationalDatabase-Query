using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace practiceEntity.Entity
{
    public class Order
    {
        public int Id { get; set; }

        public Product Product { get; set; }
        public int ProductId { get; set; }

    }
}