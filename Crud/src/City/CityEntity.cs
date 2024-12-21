using Crud.src.State;
using System.ComponentModel.DataAnnotations;
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
        [JsonIgnore]
        public Guid Id { get; set; }

        [Required]
        public string Name { get; set; }

        public Guid StateId { get; set; }

        // Foreign Key (Relation)
        public StateEntity? State { get; set; }
    }
}
