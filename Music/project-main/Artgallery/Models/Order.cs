using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Artgallery.Models
{
    [Table("Orders")]
    public class Order
    {
        [Key]
        [Column("OrderId")]
        public Guid OrderId { get; set; } = Guid.NewGuid();

        [Required(ErrorMessage = "Customer is required")]
        [Column("CustomerId")]
        public Guid CustomerId { get; set; }

        [ForeignKey("CustomerId")]
        public Customer Customer { get; set; }

        [Required]
        [Column("OrderDate")]
        public DateTime OrderDate { get; set; } = DateTime.Now;

        [Required(ErrorMessage = "Total amount is required")]
        [Range(1, 10000000, ErrorMessage = "Total amount must be greater than zero")]
        [Column("TotalAmount", TypeName = "decimal(18,2)")]
        public decimal TotalAmount { get; set; }

        [Required(ErrorMessage = "Order status is required")]
        [StringLength(50, ErrorMessage = "Order status cannot exceed 50 characters")]
        [Column("OrderStatus")]
        public string OrderStatus { get; set; }
    }
}
