using Crud.src.State;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace Crud.src.City
{
    public class CityEntity
    {
        public CityEntity()
        {
            Id = Guid.NewGuid();
        }

        [Key]
        public Guid Id { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public Guid StateId { get; set; }

        // Foreign Key (Relation)
        public StateEntity State { get; set; }
    }
}
