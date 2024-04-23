using Employee.Entity.Models;
using Employee.Repository.Contract;
using Microsoft.EntityFrameworkCore;

namespace Employee.Repository.Repository
{
    public class EmployeeRepository : IEmployeeRepository
    {
        private readonly TestDbContext _dbContext;
        public EmployeeRepository(TestDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<List<EmployeeMaster>> GetList()
        {
            List<EmployeeMaster> employeelist = new();
            try
            {
                employeelist = await _dbContext.Set<EmployeeMaster>().ToListAsync();
                return employeelist;
            }
            catch (Exception ex)
            {
                return employeelist;
            }
        }

        public async Task<EmployeeMaster> GetById(Guid id)
        {
            EmployeeMaster employee = new();
            try
            {
                employee = await _dbContext.Set<EmployeeMaster>().AsNoTracking()
                                           .Include(x => x.AddressMasters)
                                           .FirstOrDefaultAsync(e => e.EmployeeId == id);
                return employee;
            }
            catch (Exception ex)
            {
                return employee;
            }
        }

    }
}
