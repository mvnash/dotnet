using Nortwind_API.Models;
using Repository;

namespace EmployeePatternRepository.Repository
{
    interface IUnitOfWorkEmployee
    {
        IRepository<Employee> EmployeeRepository { get; }
    }
}
