using Employee.Business.Contract;
using Employee.Model;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace EmployeeData.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        private readonly IEmployeeBusiness _EmployeeBusiness;
        public EmployeeController(IEmployeeBusiness EmployeeBusiness)
        {
            _EmployeeBusiness = EmployeeBusiness;
        }

        [HttpGet()]
        public IEnumerable<EmployeeMaster> Getemployee()
        {
            var result = _EmployeeBusiness.GetEmployee();
            return result;
        }

        [HttpGet()]
        public IEnumerable<EmployeeMaster> Getemployeebyid(int id)
        {
            var result = _EmployeeBusiness.GetEmployeebyid(id);
            return result;
        }

        [HttpGet()]
        public IEnumerable<object> GetList()
        {
            var result = _EmployeeBusiness.GetList();
            return result;
        }

        [HttpGet()]
        public IEnumerable<object> GetTotalSalary(int EmpID, DateTime DateTimeFrom, DateTime DateTimeTo)
        {
            var result = _EmployeeBusiness.GetTotalSalary(EmpID, DateTimeFrom, DateTimeTo);
            return result;
        }

    }
}
