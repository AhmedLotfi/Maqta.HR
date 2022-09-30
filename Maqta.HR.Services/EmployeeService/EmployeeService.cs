using Maqta.HR.Services.EmployeeService.DTOs;

namespace Maqta.HR.Services.EmployeeService
{
    public class EmployeeService : IEmployeeService
    {
        public Task<EmployeeDto> CreateEmployee(CreateEmployeeDto createEmployeeDto)
        {
            throw new NotImplementedException();
        }

        public Task DeleteEmployee(long id)
        {
            throw new NotImplementedException();
        }

        public Task<IReadOnlyList<EmployeeDto>> GetEmployees(long? id)
        {
            throw new NotImplementedException();
        }

        public Task<EmployeeDto> UpdateEmployee(EditEmployeeDto editEmployeeDto)
        {
            throw new NotImplementedException();
        }
    }
}
