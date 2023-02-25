using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TicariOtomasyon.Entities.Abstract;

namespace TicariOtomasyon.Entities.Concrete
{
    public class Customer : IEntity
    {
        public int CustomerId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Telephone { get; set; }
        public string Telephone2 { get; set; }
        public string IdentificationNumber { get; set; }
        public string Mail { get; set; }
        public int City { get; set; }
        public int Town { get; set; }
        public string Address { get; set; }
        public string TaxAdministration { get; set; }
    }
}
