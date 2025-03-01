using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SportsWeb.CoreLayer.Entities
{
    public class Comment
    {
        public int Id { get; set; }
        [ForeignKey("User")]
        public int UserId { get; set; }
        [ForeignKey("Post")]
        public int PostId { get; set; }
        public string Content { get; set; } 
        public int? ReplyToId { get; set; }
       
        public User User { get; set; }
        public Post Post { get; set; }
        public Comment ReplyTo { get; set; }
       
        public ICollection<Like> Likes { get; set; }
        public ICollection<Comment> Replies { get; set; } 
    }
}
