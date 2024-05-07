using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace InventoryManagementSystem.Models
{
    public class Order
    {
        [Key] // Primary Key
        public int OrderId { get; set; }

        [ForeignKey("Product")]
        public int ProductId { get; set; } // Foreign Key

        public int Quantity { get; set; }
        public DateTime OrderDate { get; set; }
        public string Status { get; set; }

        // Navigation property
        public virtual Product Product { get; set; }
    }
}
