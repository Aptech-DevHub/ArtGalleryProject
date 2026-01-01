using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Artgallery.Models
{
    [Table("Payments")]
    public class Payment
    {
        [Key]
        [Column("PaymentId")]
        public Guid PaymentId { get; set; } = Guid.NewGuid();

        [Required(ErrorMessage = "Card holder name is required")]
        [StringLength(100, ErrorMessage = "Card holder name cannot exceed 100 characters")]
        [Column("CardHolderName")]
        public string CardHolderName { get; set; }

        [Required(ErrorMessage = "Account number is required")]
        [StringLength(16, MinimumLength = 12, ErrorMessage = "Account number must be between 12 and 16 digits")]
        [RegularExpression(@"^\d+$", ErrorMessage = "Account number must be numeric")]
        [Column("AccountNumber")]
        public string AccountNumber { get; set; }

        [Required(ErrorMessage = "CVC is required")]
        [StringLength(4, MinimumLength = 3, ErrorMessage = "CVC must be 3 or 4 digits")]
        [RegularExpression(@"^\d+$", ErrorMessage = "CVC must be numeric")]
        [Column("CVC")]
        public string CVC { get; set; }

        [Required(ErrorMessage = "Expiry date is required")]
        [Column("ExpiryDate", TypeName = "date")]
        public DateTime ExpiryDate { get; set; }

        [Required]
        [Column("OrderId")]
        public Guid OrderId { get; set; }

        [ForeignKey("OrderId")]
        public Order Order { get; set; }
    }
}
