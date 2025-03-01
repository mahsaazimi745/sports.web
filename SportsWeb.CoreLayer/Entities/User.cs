using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using Index = Microsoft.EntityFrameworkCore.Metadata.Internal.Index;

namespace SportsWeb.CoreLayer.Entities
{
    [Index(nameof(CreatedAt))]
    [Index(nameof(Name), nameof(PhoneNumber), Name = "IX_Users_Name_Phone")]
    public class User
    {
        public int Id { get; set; }
        public Guid UniqueId { get; set; } = Guid.NewGuid();
        public string Name { get; set; }
        public string Email { get; set; }
        public string PasswordHash { get; set; }
        public string ProfilePicture { get; set; }
        public string PhoneNumber { get; set; }
        public DateTime CreatedAt { get; set; } =DateTime.UtcNow;
        public ICollection<RoleToUser> RoleToUsers { get; set; }
        public ICollection<Post> Posts { get; set; }
        public ICollection<Comment> Comments { get; set; }
        public ICollection<Like> Likes { get; set; }
        public ICollection<Notification> Notifications { get; set; }
    }
}
