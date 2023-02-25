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
    public class CustomerManager : EntityManagerBase<Customer,EfCustomerDal>,ICustomerService
    {
        private ICustomerDal _customerDal;

        public CustomerManager(ICustomerDal customerDal)
        {
            _customerDal = customerDal;
        }
    }
}
