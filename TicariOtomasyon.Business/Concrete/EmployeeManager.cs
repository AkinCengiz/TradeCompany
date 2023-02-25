using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TicariOtomasyon.Business.Abstract;
using TicariOtomasyon.DataAccess.Abstract;
using TicariOtomasyon.DataAccess.Concrete.EntityFramework;
using TicariOtomasyon.Entities.Concrete;

namespace TicariOtomasyon.Business.Concrete
{
    public class EmployeeManager : EntityManagerBase<Employee,EfEmployeeDal>,IEmployeeService
    {
        private IEmployeeDal _employeeDal;

        public EmployeeManager(IEmployeeDal employeeDal)
        {
            _employeeDal = employeeDal;
        }
    }
}
