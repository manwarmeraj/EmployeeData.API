using Employee.ViewModels.ViewModels;

namespace Employee.Business.Contract
{
    public interface IEmployeeBusiness
    {
        Task<List<EmployeModel>> GetList();
        Task<EmployeModel> GetById(Guid id);
    }
}
