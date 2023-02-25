using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TicariOtomasyon.Entities.Abstract;

namespace TicariOtomasyon.Entities.Concrete
{
    public class Expense : IEntity
    {
        public int ExpenseId { get; set; }
        public decimal ElectricityBill { get; set; }
        public decimal WaterBill { get; set; }
        public decimal NaturalGasBill { get; set; }
        public decimal InternetBill { get; set; }
        public decimal Salaries { get; set; }
        public decimal Extra { get; set; }
        public string Notes { get; set; }
    }
}
