using Crud.src.User.Enums;
using System;
using System.ComponentModel.DataAnnotations;

namespace Crud.src.User.dto
{
    public class UserDto
    {
        public Guid Id { get; set; }

        public DateTime CreatedAt { get; set; }

        [EmailAddress]
        public string Email { get; set; }

        [DataType(DataType.Date)]
        public DateTime BirthDate { get; set; }

        public UserType PersonType { get; set; }

        public Guid? CityId { get; set; }
    }
}
