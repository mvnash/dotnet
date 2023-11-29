using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WpfEmployee.Models;

namespace WpfEmployee.ViewModels
{
    class EmployeesVM
    {
        public List<EmployeeModel> EmployeesList
        {
            get { return loadEmployee(); }
        }

        public List<string> ListTitle
        {
            get { return loadTitles(); }
        }

        private List<string> loadTitles()
        {
            List<string> titleList = new List<string>();
            

            return titleList;
        }


        private NorthwindContext context = new NorthwindContext();
         
        private List<EmployeeModel> loadEmployee()
        {
            List<EmployeeModel> employeesList = new List<EmployeeModel>();
            foreach (var item in context.Employees)
            {
                employeesList.Add(new EmployeeModel(item));

            }

            return employeesList;

        }
    }
}
