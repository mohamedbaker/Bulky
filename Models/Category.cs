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
        [Required] // Data annotation
        [StringLength(100)] // Data annotation
        public string Name { get; set; } = string.Empty;
        public int DisplayOrder { get; set; }
    }
}