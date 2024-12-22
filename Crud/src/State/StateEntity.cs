using Crud.src.Core;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Crud.src.State
{
    public class StateEntity : CoreEntity
    {
        [Required]
        public string Name { get; set; }

        [Required]
        [StringLength(2, MinimumLength = 2, ErrorMessage = "The abreviation should have 2 characters")]
        public string Abreviation { get; set; }

        [Column(TypeName = "decimal(18, 2)")]
        public decimal Area { get; set; }

        public string? FunFact { get; set; }
    }
}
