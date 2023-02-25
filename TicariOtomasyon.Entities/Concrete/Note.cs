using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TicariOtomasyon.Entities.Abstract;

namespace TicariOtomasyon.Entities.Concrete
{
    public class Note : IEntity
    {
        public int NoteId { get; set; }
        public DateTime Date { get; set; }
        public DateTime Time { get; set; }
        public string Header { get; set; }
        public string Detail { get; set; }
        public int Employee { get; set; }
    }
}
