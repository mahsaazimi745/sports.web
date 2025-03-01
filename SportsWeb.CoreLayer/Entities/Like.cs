using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SportsWeb.CoreLayer.Entities
{
    public class Like
    {
        public int Id { get; set; }
        [ForeignKey("User")]
        public int Userid { get; set; }
        [ForeignKey("Post")]
        public int  Post { get; set; }
        public User User { get; set; }
        public Post post  { get; set; }
    }
}
