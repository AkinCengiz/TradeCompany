using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TicariOtomasyon.Entities.Abstract;

namespace TicariOtomasyon.Entities.Concrete
{
    public class Invoice : IEntity
    {
        public int InvoiceId { get; set; }
        public char Serial { get; set; }
        public string Number { get; set; }
        public DateTime Date { get; set; }
        public DateTime Time { get; set; }
        public string TaxAdministration { get; set; }
        public int Customer { get; set; }
        public int Employee { get; set; }
    }
}
