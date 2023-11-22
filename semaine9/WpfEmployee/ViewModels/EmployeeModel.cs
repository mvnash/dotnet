using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WpfEmployee.Models;

namespace WpfEmployee.ViewModels
{
    class EmployeeModel
    {
        private readonly Employee _employee;


        public EmployeeModel(Employee employee)
        {
            _employee = employee;
        }


        public String FirstName
        {
            get { return _employee.FirstName; }
        }

        public string LastName
        {
            get { return _employee.LastName; }
        }

        public DateTime birthDate
        {
            get { return _employee.BirthDate ?? new DateTime(); }
        }

        public DateTime hireDate
        {
            get { return _employee.HireDate ?? new DateTime(); }
        }

        public String title
        {
            get { return _employee.Title ?? ""; }
        }



    }
}
