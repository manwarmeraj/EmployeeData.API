using Employee.Business.Contract;
using Employee.Model;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace EmployeeData.Controllers
{
    [Route("api/[controller]")]
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
    }
}
