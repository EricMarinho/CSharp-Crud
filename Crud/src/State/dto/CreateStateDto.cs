using System.ComponentModel.DataAnnotations;

namespace Crud.src.State.dto
{
    public class CreateStateDto
    {
        public string Name { get; set; }

        [StringLength(2, MinimumLength = 2, ErrorMessage = "The abbreviation should have 2 characters")]
        public string Abreviation { get; set; }

        public decimal Area { get; set; }
    }
}
