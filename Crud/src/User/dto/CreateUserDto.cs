using Crud.src.User.Enums;
using System.ComponentModel.DataAnnotations;

namespace Crud.src.User.dto
{
    public class CreateUserDto
    {
        [EmailAddress]
        public string Email { get; set; }

        [Required]
        public string Password { get; set; }

        [Required]
        public string Name { get; set; }

        public string BirthDate { get; set; }

        public UserType PersonType { get; set; }

        [Required]
        public Guid CityId { get; set; }
    }
}
