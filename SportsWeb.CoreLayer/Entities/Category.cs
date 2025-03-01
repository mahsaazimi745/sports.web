using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SportsWeb.CoreLayer.Entities
{
    public class Category
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string Slug { get; set; }
        public string MetaDescription { get; set; }
       // public string MetaTags { get; set; }
        public string Description { get; set; }
        public int? parentId { get; set; }
        public ICollection<Post> Posts { get; set; }
    }
}
