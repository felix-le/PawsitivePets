using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PawsitivePets.Models
{
    public class Pet
    {
        public int PetId { get; set; }

        [Required]
        public string Name { get; set; }

        [MaxLength(10)]
        public string Colour { get; set; }

        [Required]
        [Range(0, 99)]
        public int Age { get; set; }

        [Required]
        public int CategoryId { get; set; }

        [Required]
        public decimal Price { get; set; }

        public string Photo { get; set; }
    }
}
}
