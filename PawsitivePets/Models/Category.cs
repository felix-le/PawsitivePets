using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PawsitivePets.Models
{
    public class Category
    {
        // in .net, for PK fields, use the name {Model}Id or just Id
        [Range(1, 999999)]
        [Display(Name = "Category Id")]
        public int CategoryId { get; set; }

        [Required(ErrorMessage = "Hey don't forget me!")]
        public string Name { get; set; }
    }
}
