using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace YourProject.Models

{
	public class Product
	{
        [Key]
        public int Id { get; set; }

        [Required]
        [MinLength(2)]
        public required string Name { get; set; }

        [Required]
        public required decimal Price { get; set; }

        // Foreign key to Category
        public required int CategoryId { get; set; }

        [ForeignKey("CategoryId")]
        public required Category Category { get; set; }

        // Many-to-many with User
        public required ICollection<UserProduct> UserProducts { get; set; }
    }
} 