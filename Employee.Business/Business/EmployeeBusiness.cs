using Employee.Business.Contract;
using Employee.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee.Business.Business
{
    public class EmployeeBusiness : IEmployeeBusiness
    {
        private List<EmployeeMaster> _employee;
        public EmployeeBusiness()
        {
            List<EmployeeMaster> employee = new()
            {
                new(){EmployeeId=1,Name="Arun",Position="Jr Developer",Salary=30000,JoinDate=new DateTime(2020, 11, 08)},
                new(){EmployeeId=2,Name="Shyam",Position="Sr Developer",Salary=35000,JoinDate=new DateTime(2022, 08, 15)},
                new(){EmployeeId=3,Name="Geeta",Position="Accountant",Salary=25000,JoinDate=new DateTime(2023, 09, 20)},
                new(){EmployeeId=4,Name="Madhu",Position="Software Developer",Salary=30000,JoinDate=new DateTime(2022, 08, 22)},
                new(){EmployeeId=5,Name="Ashok",Position="Trainee Developer",Salary=20000,JoinDate=new DateTime(2021, 04, 28)},
                new(){EmployeeId=6,Name="Suvam",Position="Manager",Salary=40000,JoinDate=new DateTime(2024, 06, 29)},
                new(){EmployeeId=7,Name="Rosy",Position="Jr Developer",Salary=30000,JoinDate=new DateTime(2022, 08, 05)},
            };
            _employee = employee;
        }

        public IEnumerable<EmployeeMaster> GetEmployee()
        {
            var result = _employee;
            return result;
        }

    }
}
