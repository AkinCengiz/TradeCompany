using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TicariOtomasyon.Entities.Concrete;

namespace TicariOtomasyon.DataAccess.Abstract
{
    public interface IInvoiceDal : IEntityRepository<Invoice>
    {
    }
}
