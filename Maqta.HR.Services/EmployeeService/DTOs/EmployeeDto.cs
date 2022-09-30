namespace Maqta.HR.Services.EmployeeService.DTOs
{
    public class EmployeeDto
    {
        public long Id { get; set; }

        public string FullName { get; set; } = default!;

        public string FirstName { get; set; } = default!;

        public string LastName { get; set; } = default!;

        public string Email { get; set; } = default!;
    }
}
