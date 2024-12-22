using System.ComponentModel.DataAnnotations;
using Crud.src.City;
using Crud.src.User.Enums;

namespace Crud.src.User
{
    public class UserEntity
    {
        public UserEntity()
        {
            Id = Guid.NewGuid();
            CreatedAt = DateTime.Now.ToString();
        }

        [Key]
        public Guid Id { get; set; }

        public string CreatedAt { get; set; }

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
