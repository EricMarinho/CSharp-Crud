using Crud.src.Core;
using Crud.src.State;
using System.ComponentModel.DataAnnotations;

namespace Crud.src.City
{
    public class CityEntity : CoreEntity
    {
        [Required]
        public string Name { get; set; }

        [Required]
        public Guid StateId { get; set; }

        // Foreign Key (Relation)
        public StateEntity State { get; set; }
    }
}
