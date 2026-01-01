using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Artgallery.Models
{
    [Table("Arts")]
    public class Art
    {
        [Key]
        [Column("ArtId")]
        public Guid ArtId { get; set; } = Guid.NewGuid();

        [Required(ErrorMessage = "Title is required")]
        [StringLength(150, ErrorMessage = "Title cannot exceed 150 characters")]
        [Column("Title")]
        public string Title { get; set; }

        [Required(ErrorMessage = "Description is required")]
        [StringLength(1000, ErrorMessage = "Description cannot exceed 1000 characters")]
        [Column("Description")]
        public string Description { get; set; } 

        [Required(ErrorMessage = "Price is required")]
        [Range(1, 1000000, ErrorMessage = "Price must be between 1 and 1,000,000")]
        [Column("Price", TypeName = "decimal(18,2)")]
        public decimal Price { get; set; }

        [Required(ErrorMessage = "Image is required")]
        [Column("ImagePath")]
        public string Image { get; set; }

        [Required(ErrorMessage = "Availability is required")]
        [Range(0, 1000, ErrorMessage = "Availability must be between 0 and 1000")]
        [Column("Availability")]
        public int Availability { get; set; }

        [Required(ErrorMessage = "Category is required")]
        [Column("CategoryId")]
        public Guid CategoryId { get; set; }

        [ForeignKey("CategoryId")]
        public Category Category { get; set; }
    }
}
