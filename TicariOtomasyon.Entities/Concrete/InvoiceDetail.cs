using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TicariOtomasyon.Entities.Abstract;

namespace TicariOtomasyon.Entities.Concrete
{
    public class InvoiceDetail : IEntity
    {
        public Int16 InvoiceDetailID { get; set; }
        public int Product { get; set; }
        public Int16 Amount { get; set; }
        public decimal TotalPrice { get; set; }
        public int Invoices { get; set; }
    }
}
