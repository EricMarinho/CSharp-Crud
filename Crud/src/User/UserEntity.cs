using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Crud.src.City;
using Crud.src.User.Enums;

namespace Crud.src.User
{
    public class UserEntity
    {
        public UserEntity()
        {
            Id = Guid.NewGuid();
            CreatedAt = DateTime.Now;
        }

        [Key]
        public Guid Id { get; set; }

        [DataType(DataType.Date)]
        public DateTime CreatedAt { get; set; }

        [Required]
        public string Name { get; set; }

        [EmailAddress]
        public string Email { get; set; }

        [DataType(DataType.Password)]
        public string Password { get; set; }

        [DataType(DataType.Date)]
        public DateTime BirthDate { get; set; }

        [Required]
        public UserType PersonType { get; set; }

        // Not Required, can be null
        public Guid? CityId { get; set; }

        // Foreign Key (Relation)
        public CityEntity City { get; set; }
    }
}
