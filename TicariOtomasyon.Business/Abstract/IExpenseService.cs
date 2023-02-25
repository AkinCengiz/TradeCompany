using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TicariOtomasyon.DataAccess.Concrete.EntityFramework;
using TicariOtomasyon.Entities.Concrete;

namespace TicariOtomasyon.Business.Abstract
{
    public interface IExpenseService : IEntityService<Expense,EfExpenseDal>
    {
    }
}
