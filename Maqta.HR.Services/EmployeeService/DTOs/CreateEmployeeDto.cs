namespace Maqta.HR.Services.EmployeeService.DTOs
{
    public class CreateEmployeeDto
    {
        public long Id { get; set; }

        public string FirstName { get; set; } = default!;

        public string LastName { get; set; } = default!;

        public string Email { get; set; } = default!;

        public string Password { get; set; } = default!;
    }
}
