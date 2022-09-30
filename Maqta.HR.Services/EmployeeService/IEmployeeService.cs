using Maqta.HR.Services.EmployeeService.DTOs;

namespace Maqta.HR.Services.EmployeeService
{
    public interface IEmployeeService
    {
        Task<EmployeeDto> CreateEmployee(CreateEmployeeDto createEmployeeDto);
        Task<EmployeeDto> UpdateEmployee(EditEmployeeDto editEmployeeDto);
        Task<IReadOnlyList<EmployeeDto>> GetEmployees(long? id);
        Task DeleteEmployee(long id);
    }
}
