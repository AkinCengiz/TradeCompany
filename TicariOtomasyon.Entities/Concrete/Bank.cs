using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TicariOtomasyon.Entities.Abstract;

namespace TicariOtomasyon.Entities.Concrete
{
    public class Bank : IEntity
    {
        public byte BankId { get; set; }
        public string BankName { get; set; }
        public string Branch { get; set; }
        public string IBAN { get; set; }
        public string AccountNumber { get; set; }
        public string Official { get; set; }
        public DateTime Date { get; set; }
        public string AccountType { get; set; }
    }
}
