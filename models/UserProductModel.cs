using System.ComponentModel.DataAnnotations.Schema;

namespace YourProject.Models
{
    public class UserProduct
    {
        // Composite key will be configured in DbContext

        public required int UserId { get; set; }

        [ForeignKey("UserId")]
        public required User User { get; set; }

        public required int ProductId { get; set; }

        [ForeignKey("ProductId")]
        public required Product Product { get; set; }
    }
}