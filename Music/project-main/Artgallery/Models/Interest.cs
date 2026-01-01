using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace Artgallery.Models
{
    public class Interest
    {
       [Key]
       public Guid id { get; set; }

       [Column("interest",TypeName="varchar(50)")]
       public string Name { get; set; }

    }
}
