using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BulkyApp.Models
{
    public class Category
    {
        //"prop" tab twice shortcut for peoperty
        [Key] // Data annotation but if the prop name is just id
        // Entity Framework will automatically consider it as the primary key
        public int Id { get; set; }

        [Required]
        [StringLength(100)]
        [Display(Name = "Category Name")]
        public string Name { get; set; } = string.Empty;

        [Display(Name = "Display Order")]
        public int DisplayOrder { get; set; }
    }
}
