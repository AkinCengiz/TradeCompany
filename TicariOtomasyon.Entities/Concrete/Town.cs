using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TicariOtomasyon.Entities.Abstract;

namespace TicariOtomasyon.Entities.Concrete
{
    public class Town : IEntity
    {
        public int TownId { get; set; }
        public string TownName { get; set; }
        public int City { get; set; }
    }
}
