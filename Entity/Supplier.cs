using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace practiceEntity.Entity
{
    public class Supplier
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int TaxNumber { get; set; }

        public User User { get; set; }
        public int UserId { get; set; }
    }
}