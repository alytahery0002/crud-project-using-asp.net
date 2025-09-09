using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace YourProject.Models

{
    public class User
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [MinLength(2)]
        public required string Name { get; set; }

        // Navigation property
        public  ICollection<UserProduct>  UserProducts { get; set; } = new List<UserProduct>();
    }
}