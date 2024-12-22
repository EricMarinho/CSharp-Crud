using System.ComponentModel.DataAnnotations;

namespace Crud.src.Core
{
    public class CoreEntity
    {
        public CoreEntity()
        {
            Id = Guid.NewGuid();
            CreatedAt = DateTime.Now.ToString();
            UpdatedAt = DateTime.Now.ToString();
        }

        [Key]
        public Guid Id { get; set; }

        public string CreatedAt { get; set; }

        public string UpdatedAt { get; set; }
    }
}
