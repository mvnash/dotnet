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
        private List<EmployeeModel> _employeeList;
        private NorthwindContext context = new NorthwindContext();

        private List<EmployeeModel> loadEmployee()
        {
            List<EmployeeModel> localCollection = new List<EmployeeModel>();
            foreach (var item in context.Employees)
            {
                localCollection.Add(new EmployeeModel(item));

            }

            return localCollection;

        }
    }
}
