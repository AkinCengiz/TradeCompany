using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TicariOtomasyon.DataAccess.Abstract;
using TicariOtomasyon.Entities.Concrete;

namespace TicariOtomasyon.DataAccess.Concrete.EntityFramework
{
    public class EfNoteDal : EfEntityRepositoryBase<Note,TradeCompanyContext>,INoteDal
    {
    }
}
