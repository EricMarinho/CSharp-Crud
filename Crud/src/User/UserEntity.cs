using System.ComponentModel.DataAnnotations;
using Crud.src.City;
using Crud.src.Core;
using Crud.src.User.Enums;

namespace Crud.src.User
{
    public class UserEntity: CoreEntity
    {
        [Required]
        public string Name { get; set; }

        [EmailAddress]
        public string Email { get; set; }

        [DataType(DataType.Password)]
        public string Password { get; set; }

        public string BirthDate { get; set; }

        [Required]
        public UserType PersonType { get; set; }

        [Required]
        public Guid CityId { get; set; }

        // Foreign Key (Relation)
        public CityEntity City { get; set; }
    }
}
