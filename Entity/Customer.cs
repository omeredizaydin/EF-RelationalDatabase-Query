using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace practiceEntity.Entity
{
    public class Customer
    {
        public int Id { get; set; }
        public int IdentityNumber { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public User User { get; set; }
        public int UserId { get; set; }
    }

}