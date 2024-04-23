using Employee.Business.Contract;
using Microsoft.AspNetCore.Mvc;

namespace EmployeeData.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        private readonly IEmployeeBusiness _employeeBusiness;
        public EmployeeController(IEmployeeBusiness EmployeeBusiness)
        {
            _employeeBusiness = EmployeeBusiness;
        }

        [HttpGet]
        public async Task<IActionResult> GetList()
        {
            var result = await _employeeBusiness.GetList();

            if (!result.Any())
                return BadRequest();

            return Ok(result);
        }

        [HttpGet]
        public async Task<IActionResult> GetById([FromHeader] Guid id)
        {
            var result = await _employeeBusiness.GetById(id);

            if (result == null)
                return BadRequest();

            return Ok(result);
        }
    }
}
