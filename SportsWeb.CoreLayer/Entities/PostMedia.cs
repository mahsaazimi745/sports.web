using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SportsWeb.CoreLayer.Entities
{
    public class PostMedia
    {
        [Key]
        public int  Id { get; set; }
        public string FileUrl { get; set; }
        public DateTime CreatedAt { get; set; }
        [ForeignKey("post")]
        public int PostId { get; set; }
        public Post Post { get; set; }
    }
}
