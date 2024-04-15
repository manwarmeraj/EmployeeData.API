using Employee.Business.Contract;
using Employee.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Employee.Business.Business
{
    public class EmployeeBusiness : IEmployeeBusiness
    {
        private List<EmployeeMaster> _employee;
        private List<EmployeeSalary> _employeesalary;
        public EmployeeBusiness()
        {
            List<EmployeeMaster> employee = new()
            {
                new(){EmployeeId=1,Name="Arun",Position="Jr Developer",JoinDate=new DateTime(2020, 11, 08)},
                new(){EmployeeId=2,Name="Shyam",Position="Sr Developer",JoinDate=new DateTime(2022, 08, 15)},
                new(){EmployeeId=3,Name="Geeta",Position="Accountant",JoinDate=new DateTime(2023, 09, 20)},
                new(){EmployeeId=4,Name="Madhu",Position="Software Developer",JoinDate=new DateTime(2022, 08, 22)},
                new(){EmployeeId=5,Name="Ashok",Position="Trainee Developer",JoinDate=new DateTime(2021, 04, 28)},
                new(){EmployeeId=6,Name="Suvam",Position="Manager",JoinDate=new DateTime(2024, 06, 29)},
                new(){EmployeeId=7,Name="Rosy",Position="Jr Developer",JoinDate=new DateTime(2022, 08, 05)},
            };
            _employee = employee;

            List<EmployeeSalary> employeesalary = new()
            {
                new(){EmployeeId=1,Salary=20000,CreditedDate=new DateTime(2023, 01, 01)},
                new(){EmployeeId=2,Salary=25000,CreditedDate=new DateTime(2023, 01, 01)},
                new(){EmployeeId=3,Salary=20000,CreditedDate=new DateTime(2023, 01, 01)},
                new(){EmployeeId=4,Salary=30000,CreditedDate=new DateTime(2023, 01, 01)},
                new(){EmployeeId=5,Salary=20000,CreditedDate=new DateTime(2023, 01, 01)},
                new(){EmployeeId=6,Salary=40000,CreditedDate=new DateTime(2023, 01, 01)},
                new(){EmployeeId=7,Salary=30000,CreditedDate=new DateTime(2023, 01, 01)},

                new(){EmployeeId=1,Salary=20000,CreditedDate=new DateTime(2023, 02, 01)},
                new(){EmployeeId=2,Salary=25000,CreditedDate=new DateTime(2023, 02, 01)},
                new(){EmployeeId=3,Salary=20000,CreditedDate=new DateTime(2023, 02, 01)},
                new(){EmployeeId=4,Salary=30000,CreditedDate=new DateTime(2023, 02, 01)},
                new(){EmployeeId=5,Salary=20000,CreditedDate=new DateTime(2023, 02, 01)},
                new(){EmployeeId=6,Salary=40000,CreditedDate=new DateTime(2023, 02, 01)},
                new(){EmployeeId=7,Salary=30000,CreditedDate=new DateTime(2023, 02, 01)},

                new(){EmployeeId=1,Salary=20000,CreditedDate=new DateTime(2023, 03, 01)},
                new(){EmployeeId=2,Salary=25000,CreditedDate=new DateTime(2023, 03, 01)},
                new(){EmployeeId=3,Salary=20000,CreditedDate=new DateTime(2023, 03, 01)},
                new(){EmployeeId=4,Salary=30000,CreditedDate=new DateTime(2023, 03, 01)},
                new(){EmployeeId=5,Salary=20000,CreditedDate=new DateTime(2023, 03, 01)},
                new(){EmployeeId=6,Salary=40000,CreditedDate=new DateTime(2023, 03, 01)},
                new(){EmployeeId=7,Salary=30000,CreditedDate=new DateTime(2023, 03, 01)},

                new(){EmployeeId=1,Salary=25250,CreditedDate=new DateTime(2023, 04, 03)},
                new(){EmployeeId=2,Salary=30300,CreditedDate=new DateTime(2023, 04, 03)},
                new(){EmployeeId=3,Salary=25110,CreditedDate=new DateTime(2023, 04, 03)},
                new(){EmployeeId=4,Salary=40150,CreditedDate=new DateTime(2023, 04, 03)},
                new(){EmployeeId=5,Salary=25000,CreditedDate=new DateTime(2023, 04, 03)},
                new(){EmployeeId=6,Salary=50020,CreditedDate=new DateTime(2023, 04, 03)},
                new(){EmployeeId=7,Salary=38180,CreditedDate=new DateTime(2023, 04, 03)},

                new(){EmployeeId=1,Salary=25250,CreditedDate=new DateTime(2023, 05, 05)},
                new(){EmployeeId=2,Salary=30300,CreditedDate=new DateTime(2023, 05, 05)},
                new(){EmployeeId=3,Salary=25110,CreditedDate=new DateTime(2023, 05, 05)},
                new(){EmployeeId=4,Salary=40150,CreditedDate=new DateTime(2023, 05, 05)},
                new(){EmployeeId=5,Salary=25000,CreditedDate=new DateTime(2023, 05, 05)},
                new(){EmployeeId=6,Salary=50020,CreditedDate=new DateTime(2023, 05, 05)},
                new(){EmployeeId=7,Salary=38180,CreditedDate=new DateTime(2023, 05, 05)},

                new(){EmployeeId=1,Salary=25250,CreditedDate=new DateTime(2023, 06, 01)},
                new(){EmployeeId=2,Salary=30300,CreditedDate=new DateTime(2023, 06, 01)},
                new(){EmployeeId=3,Salary=25110,CreditedDate=new DateTime(2023, 06, 01)},
                new(){EmployeeId=4,Salary=40150,CreditedDate=new DateTime(2023, 06, 01)},
                new(){EmployeeId=5,Salary=25000,CreditedDate=new DateTime(2023, 06, 01)},
                new(){EmployeeId=6,Salary=50020,CreditedDate=new DateTime(2023, 06, 01)},
                new(){EmployeeId=7,Salary=38180,CreditedDate=new DateTime(2023, 06, 01)},

                new(){EmployeeId=1,Salary=25250,CreditedDate=new DateTime(2023, 07, 02)},
                new(){EmployeeId=2,Salary=30300,CreditedDate=new DateTime(2023, 07, 02)},
                new(){EmployeeId=3,Salary=25110,CreditedDate=new DateTime(2023, 07, 02)},
                new(){EmployeeId=4,Salary=40150,CreditedDate=new DateTime(2023, 07, 02)},
                new(){EmployeeId=5,Salary=25000,CreditedDate=new DateTime(2023, 07, 02)},
                new(){EmployeeId=6,Salary=50020,CreditedDate=new DateTime(2023, 07, 02)},
                new(){EmployeeId=7,Salary=38180,CreditedDate=new DateTime(2023, 07, 02)},

                new(){EmployeeId=1,Salary=25250,CreditedDate=new DateTime(2023, 08, 02)},
                new(){EmployeeId=2,Salary=30300,CreditedDate=new DateTime(2023, 08, 02)},
                new(){EmployeeId=3,Salary=25110,CreditedDate=new DateTime(2023, 08, 02)},
                new(){EmployeeId=4,Salary=40150,CreditedDate=new DateTime(2023, 08, 02)},
                new(){EmployeeId=5,Salary=25000,CreditedDate=new DateTime(2023, 08, 02)},
                new(){EmployeeId=6,Salary=50020,CreditedDate=new DateTime(2023, 08, 02)},
                new(){EmployeeId=7,Salary=38180,CreditedDate=new DateTime(2023, 08, 02)},

                new(){EmployeeId=1,Salary=25250,CreditedDate=new DateTime(2023, 09, 07)},
                new(){EmployeeId=2,Salary=30300,CreditedDate=new DateTime(2023, 09, 07)},
                new(){EmployeeId=3,Salary=25110,CreditedDate=new DateTime(2023, 09, 07)},
                new(){EmployeeId=4,Salary=40150,CreditedDate=new DateTime(2023, 09, 07)},
                new(){EmployeeId=5,Salary=25000,CreditedDate=new DateTime(2023, 09, 07)},
                new(){EmployeeId=6,Salary=50020,CreditedDate=new DateTime(2023, 09, 07)},
                new(){EmployeeId=7,Salary=38180,CreditedDate=new DateTime(2023, 09, 07)},

                new(){EmployeeId=1,Salary=25250,CreditedDate=new DateTime(2023, 10, 01)},
                new(){EmployeeId=2,Salary=30300,CreditedDate=new DateTime(2023, 10, 01)},
                new(){EmployeeId=3,Salary=25110,CreditedDate=new DateTime(2023, 10, 01)},
                new(){EmployeeId=4,Salary=40150,CreditedDate=new DateTime(2023, 10, 01)},
                new(){EmployeeId=5,Salary=25000,CreditedDate=new DateTime(2023, 10, 01)},
                new(){EmployeeId=6,Salary=50020,CreditedDate=new DateTime(2023, 10, 01)},
                new(){EmployeeId=7,Salary=38180,CreditedDate=new DateTime(2023, 10, 01)},

                new(){EmployeeId=1,Salary=25250,CreditedDate=new DateTime(2023, 11, 01)},
                new(){EmployeeId=2,Salary=30300,CreditedDate=new DateTime(2023, 11, 01)},
                new(){EmployeeId=3,Salary=25110,CreditedDate=new DateTime(2023, 11, 01)},
                new(){EmployeeId=4,Salary=40150,CreditedDate=new DateTime(2023, 11, 01)},
                new(){EmployeeId=5,Salary=25000,CreditedDate=new DateTime(2023, 11, 01)},
                new(){EmployeeId=6,Salary=50020,CreditedDate=new DateTime(2023, 11, 01)},
                new(){EmployeeId=7,Salary=38180,CreditedDate=new DateTime(2023, 11, 01)},

                new(){EmployeeId=1,Salary=25250,CreditedDate=new DateTime(2023, 12, 02)},
                new(){EmployeeId=2,Salary=30300,CreditedDate=new DateTime(2023, 12, 02)},
                new(){EmployeeId=3,Salary=25110,CreditedDate=new DateTime(2023, 12, 02)},
                new(){EmployeeId=4,Salary=40150,CreditedDate=new DateTime(2023, 12, 02)},
                new(){EmployeeId=5,Salary=25000,CreditedDate=new DateTime(2023, 12, 02)},
                new(){EmployeeId=6,Salary=50020,CreditedDate=new DateTime(2023, 12, 02)},
                new(){EmployeeId=7,Salary=38180,CreditedDate=new DateTime(2023, 12, 02)},

                new(){EmployeeId=1,Salary=25250,CreditedDate=new DateTime(2024, 01, 02)},
                new(){EmployeeId=2,Salary=30300,CreditedDate=new DateTime(2024, 01, 02)},
                new(){EmployeeId=3,Salary=25110,CreditedDate=new DateTime(2024, 01, 02)},
                new(){EmployeeId=4,Salary=40150,CreditedDate=new DateTime(2024, 01, 02)},
                new(){EmployeeId=5,Salary=25000,CreditedDate=new DateTime(2024, 01, 02)},
                new(){EmployeeId=6,Salary=50020,CreditedDate=new DateTime(2024, 01, 02)},
                new(){EmployeeId=7,Salary=38180,CreditedDate=new DateTime(2024, 01, 02)},

                new(){EmployeeId=1,Salary=25250,CreditedDate=new DateTime(2024, 02, 02)},
                new(){EmployeeId=2,Salary=30300,CreditedDate=new DateTime(2024, 02, 02)},
                new(){EmployeeId=3,Salary=25110,CreditedDate=new DateTime(2024, 02, 02)},
                new(){EmployeeId=4,Salary=40150,CreditedDate=new DateTime(2024, 02, 02)},
                new(){EmployeeId=5,Salary=25000,CreditedDate=new DateTime(2024, 02, 02)},
                new(){EmployeeId=6,Salary=50020,CreditedDate=new DateTime(2024, 02, 02)},
                new(){EmployeeId=7,Salary=38180,CreditedDate=new DateTime(2024, 02, 02)},

                new(){EmployeeId=1,Salary=25250,CreditedDate=new DateTime(2024, 03, 02)},
                new(){EmployeeId=2,Salary=30300,CreditedDate=new DateTime(2024, 03, 02)},
                new(){EmployeeId=3,Salary=25110,CreditedDate=new DateTime(2024, 03, 02)},
                new(){EmployeeId=4,Salary=40150,CreditedDate=new DateTime(2024, 03, 02)},
                new(){EmployeeId=5,Salary=25000,CreditedDate=new DateTime(2024, 03, 02)},
                new(){EmployeeId=6,Salary=50020,CreditedDate=new DateTime(2024, 03, 02)},
                new(){EmployeeId=7,Salary=38180,CreditedDate=new DateTime(2024, 03, 02)},
            };
            _employeesalary = employeesalary;
        }

        public IEnumerable<EmployeeMaster> GetEmployee()
        {
            var result = _employee;
            return result;
        }
        public IEnumerable<EmployeeMaster> GetEmployeebyid(int id)
        {
            var result = _employee.Where(q => q.EmployeeId == id);
            return result;
        }

        public IEnumerable<object> GetList()
        {
            var result = from salary in _employeesalary
                                join emp in _employee
                                on salary.EmployeeId equals emp.EmployeeId
                                group new { salary, emp } by new { emp.EmployeeId, emp.Name } into grouped
                                select new
                                {
                                    EmployeeId = grouped.Key.EmployeeId,//Grouped . key is a composite key
                                    Name = grouped.Key.Name,
                                    SumOfSalary = grouped.Sum(item => item.salary.Salary)
                                };
            return result;
        }

        public IEnumerable<object> GetTotalSalary(int EmpId, DateTime DateTimeFrom, DateTime DateTimeTo)
        {
            var totalSalaries = from salary in _employeesalary
                                 join emp in _employee
                                 on salary.EmployeeId equals emp.EmployeeId
                                 where salary.EmployeeId== EmpId && salary.CreditedDate>= DateTimeFrom && salary.CreditedDate<= DateTimeTo
                                 group new { salary, emp } by new { emp.EmployeeId, emp.Name } into grouped
                                 select new
                                 {
                                     EmployeeId = grouped.Key.EmployeeId,//Grouped . key is a composite key
                                     Name = grouped.Key.Name,
                                     SumOfSalary = grouped.Sum(item => item.salary.Salary)
                                 };
            return totalSalaries;
        }


    }
}
