using Employee.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee.Business.Contract
{
    public interface IEmployeeBusiness
    {
        IEnumerable<EmployeeMaster> GetEmployee();
    }
}
