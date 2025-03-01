using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SportsWeb.CoreLayer.Entities
{
   public class Notification
    {
        public int Id { get; set; }
        public Guid UniqueId { get; set; } = Guid.NewGuid();
        [ForeignKey("User")]
        public int  UserId { get; set; }
        public string Message { get; set; } = string.Empty;
        public bool IsRead { get; set; } = false;
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;


        public int? ReferenceId { get; set; }
        [ForeignKey("Post")]
        public int? PostId { get; set; }
        [ForeignKey("omment")]
        public int? CommentId { get; set; }
        [ForeignKey("Like")]
        public int? LikeId { get; set; }

        // Navigation Properties
        public User User { get; set; }
        public Post Post { get; set; }
        public Comment Comment { get; set; }
        public Like Like { get; set; }
    }
}
