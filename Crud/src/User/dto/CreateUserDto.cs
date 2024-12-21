using Crud.src.User.Enums;
using System;
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

        [Required]
        public DateTime BirthDate { get; set; }

        public UserType PersonType { get; set; }

        public Guid? CityId { get; set; }
    }
}
