using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Artgallery.Models
{
    [Table("Users")]
    public class User
    {
        [Key]
        [Column("UserId")]
        public Guid UserId { get; set; } = Guid.NewGuid();

        [Required(ErrorMessage = "Name is required")]
        [StringLength(100, ErrorMessage = "Name cannot exceed 100 characters")]
        [Column("Name")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Age is required")]
        [Range(1, 120, ErrorMessage = "Age must be between 1 and 120")]
        [Column("Age")]
        public int Age { get; set; }

        [Required(ErrorMessage = "Gender is required")]
        [StringLength(10, ErrorMessage = "Gender cannot exceed 10 characters")]
        [Column("Gender")]
        public string Gender { get; set; }

        [Required(ErrorMessage = "Email is required")]
        [EmailAddress(ErrorMessage = "Invalid email address")]
        [Column("Email")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Password is required")]
        [StringLength(100, MinimumLength = 6, ErrorMessage = "Password must be at least 6 characters")]
        [Column("Password")]
        public string Password { get; set; }

        [Required(ErrorMessage = "Role is required")]
        [StringLength(20, ErrorMessage = "Role cannot exceed 20 characters")]
        [Column("Role")]
        public string Role { get; set; }

        [Required(ErrorMessage = "Address is required")]
        [StringLength(200, ErrorMessage = "Address cannot exceed 200 characters")]
        [Column("Address")]
        public string Address { get; set; }

        [Required]
        [Column("CreatedAt")]
        public DateTime CreatedAt { get; set; } = DateTime.Now;
    }
}
