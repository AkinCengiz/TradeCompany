using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TicariOtomasyon.Business.Abstract;
using TicariOtomasyon.Business.Concrete;
using TicariOtomasyon.DataAccess.Concrete.EntityFramework;

namespace TicariOtomasyon.WindowsFormsUI
{
    public partial class Form1 : Form
    {
        private IEmployeeService _employeeService;
        private ICustomerService _customerService;

        public Form1()
        {
            InitializeComponent();
            _employeeService = new EmployeeManager(new EfEmployeeDal());
            _customerService = new CustomerManager(new EfCustomerDal());
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dgvEmployees.DataSource = _employeeService.GetAll();
            dgvCustomers.DataSource = _customerService.GetAll();
        }
    }
}
