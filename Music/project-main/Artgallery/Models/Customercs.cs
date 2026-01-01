using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Artgallery.Models
{
    [Table("Customers")]
    public class Customer
    {
        [Key]
        [Column("CustomerId")]
        public Guid CustomerId { get; set; } = Guid.NewGuid();

        [Required(ErrorMessage = "Phone number is required")]
        [StringLength(15, ErrorMessage = "Phone number cannot exceed 15 digits")]
        [RegularExpression(@"^\+?\d+$", ErrorMessage = "Phone number must be numeric")]
        [Column("Phone")]
        public string Phone { get; set; }

        [Required(ErrorMessage = "Country is required")]
        [StringLength(100, ErrorMessage = "Country name cannot exceed 100 characters")]
        [Column("Country")]
        public string Country { get; set; }

        [Required(ErrorMessage = "User is required")]
        [Column("UserId")]
        public Guid UserId { get; set; }

        [ForeignKey("UserId")]
        public User User { get; set; }
    }
}
