using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Maqta.HR.Domain.Models
{
    public class Employee
    {
        public int Id { get; set; }

        [Required]
        [MaxLength(150)]
        public string FirstName { get; set; } = default!;

        [Required]
        [MaxLength(150)]
        public string LastName { get; set; } = default!;

        [Required]
        [MaxLength(100)]
        public string Email { get; set; } = default!;

        [Required]
        [MaxLength(300)]
        public string Password { get; set; } = default!;

        [NotMapped]
        public string FullName => $"{FirstName} {LastName}";
    }
}
