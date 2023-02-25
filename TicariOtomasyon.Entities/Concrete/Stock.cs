using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TicariOtomasyon.Entities.Abstract;

namespace TicariOtomasyon.Entities.Concrete
{
    public class Stock : IEntity
    {
        public int StockId { get; set; }
        public string StockType { get; set; }
        public Int16 StockAmount { get; set; }
    }
}
