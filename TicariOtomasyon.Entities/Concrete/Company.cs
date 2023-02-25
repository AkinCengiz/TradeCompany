using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TicariOtomasyon.Entities.Abstract;

namespace TicariOtomasyon.Entities.Concrete
{
    public class Company : IEntity
    {
        public Int16 CompanyId { get; set; }
        public string CompanyName { get; set; }
        public string OfficialStatu { get; set; }
        public string OfficialName { get; set; }
        public string OfficialSurname { get; set; }
        public string Telephone { get; set; }
        public string Telephone2 { get; set; }
        public string Telephone3 { get; set; }
        public string Fax { get; set; }
        public string Mail { get; set; }
        public int City { get; set; }
        public int Town { get; set; }
        public string TaxAdministration { get; set; }
        public string Address { get; set; }

    }
}
