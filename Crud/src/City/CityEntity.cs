﻿using Crud.src.State;
using System.ComponentModel.DataAnnotations;

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

        // Foreign Key (Relation)
        public StateEntity State { get; set; }
    }
}
