using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace InventoryManagementSystem.Models
{
    public class Product
    {
        [Key] // Denotes this property as the primary key
        public int ProductId { get; set; }

        [Required]
        [StringLength(100)] // Limiting the length of the name to 100 characters
        public string Name { get; set; }

        [Required]
        [Column(TypeName = "decimal(18, 2)")] // Specifies the data type and precision for the price
        public decimal Price { get; set; }

        [StringLength(500)] // Limiting the length of the description to 500 characters
        public string Description { get; set; }
    }
}
