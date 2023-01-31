using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace practiceEntity.Entity
{
    public class User
    {
        public User()
        {
            this.Addresses = new List<Address>();
        }
        public int Id { get; set; }
        public string UserName { get; set; }
        public string Email { get; set; }

        public Customer Customer { get; set; }
        public Supplier Supplier { get; set; }
        public List<Address> Addresses { get; set; }
    }
}