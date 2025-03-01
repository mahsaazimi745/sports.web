using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace SportsWeb.CoreLayer.Entities
{
    [Index(nameof(CreatedAt), nameof(AuthorId))]
    public class Post
    {
        [Key]
        public int Id { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        [ForeignKey("User")]
        public int AuthorId { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        [ForeignKey("Category")]
        public int CategoryId { get; set; }
        
        public User Author { get; set; }
        public Category Category { get; set; }
        public ICollection<Tag> Tags { get; set; }
        public ICollection<Like> Likes { get; set; }
        public ICollection<Comment> Comments { get; set; }
        public ICollection<PostMedia> MediaFiles { get; set; }

        /* public enum MediaType
         {
             Image,
             Video
         }*/
    }
}
