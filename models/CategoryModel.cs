using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace YourProject.Models
{
    public class Category
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [MinLength(2)]
        public required string Name { get; set; }

        public required ICollection<Product> Products { get; set; }
    }
}