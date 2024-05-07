using System.ComponentModel.DataAnnotations.Schema;

namespace InventoryManagementSystem.Models
{
    public class Sale
    {
        public int SaleId { get; set; }

        [ForeignKey("Order")]
        public int OrderId { get; set; } // Foreign Key

        public DateTime SaleDate { get; set; }
        public decimal TotalAmount { get; set; }

        // Navigation property
        public virtual Order Order { get; set; }
    }
}
