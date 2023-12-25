using System.ComponentModel.DataAnnotations;

namespace WebApiTest.Model
{
    public class User
    {
        public int Id { get; set; }

        [Required]
        [MinLength(2)]
        public required string Name { get; set; }

        [Required]
        [EmailAddress]
        public required string Email { get; set; }

        [Required]
        [MinLength(5)]
        public required string Password { get; set; }
    }
}
