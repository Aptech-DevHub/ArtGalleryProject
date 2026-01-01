using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Artgallery.Models
{
    [Table("Categories")]
    public class Category
    {
        [Key]
        [Column("CategoryId")]
        public Guid CategoryId { get; set; } = Guid.NewGuid();

        [Required(ErrorMessage = "Category name is required")]
        [StringLength(100, ErrorMessage = "Category name cannot exceed 100 characters")]
        [Column("Name")]
        public string Name { get; set; }

     
        public ICollection<Art> Arts { get; set; } = new List<Art>();
    }
}
