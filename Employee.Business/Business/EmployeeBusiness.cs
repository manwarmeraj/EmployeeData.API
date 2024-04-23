using AutoMapper;
using Employee.Business.Contract;
using Employee.Repository.Contract;
using Employee.ViewModels.ViewModels;

namespace Employee.Business.Business
{
    public class EmployeeBusiness : IEmployeeBusiness
    {
        private readonly IEmployeeRepository _employeeRepository;
        private readonly IMapper _mapper;
        public EmployeeBusiness(IEmployeeRepository employeeRepository, IMapper mapper)
        {
            _employeeRepository = employeeRepository;
            _mapper = mapper;
        }

        public async Task<List<EmployeModel>> GetList()
        {
            List<EmployeModel> employeeList = new();

            var result = await _employeeRepository.GetList();

            employeeList = _mapper.Map<List<EmployeModel>>(result);
            return employeeList;
        }

        public async Task<EmployeModel> GetById(Guid id)
        {
            EmployeModel employeeData = new();

            var result = await _employeeRepository.GetById(id);

            employeeData = _mapper.Map<EmployeModel>(result);
            return employeeData;
        }
    }
}
