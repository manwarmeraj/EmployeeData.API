using Employee.Entity.Models;

namespace Employee.Repository.Contract
{
    public interface IEmployeeRepository
    {
        Task<List<EmployeeMaster>> GetList();
        Task<EmployeeMaster> GetById(Guid id);
    }
}
