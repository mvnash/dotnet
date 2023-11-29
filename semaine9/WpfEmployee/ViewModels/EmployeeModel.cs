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


        public string FirstName
        {
            get { return _employee.FirstName; }
            set { _employee.FirstName = value; }
        }

        public string LastName
        {
            get { return _employee.LastName; }
            set { _employee.LastName = value; } 
        }

        public string FullName
        {
            get { return FirstName + " " + LastName; }
        }

        public DateTime? BirthDate
        {
            get { return _employee.BirthDate; }
            set { _employee.BirthDate = value; }
        }

        public DateTime? DisplayBirthDate
        {
            get { return BirthDate; }
        }

        public DateTime? HireDate
        {
            get { return _employee.HireDate; }
            set
            {
                _employee.HireDate = value;
            }
        }

        public string Title
        {
            get { return _employee.Title ?? ""; }
            set { _employee.Title = value; }
        }



    }
}
