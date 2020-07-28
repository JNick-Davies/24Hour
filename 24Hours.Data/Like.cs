using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _24Hours.Data
{
    public class Like
    {
        [Key]
        public int LikeId { get; set; }
        [Required]
        public int PostId { get; set; }
        [ForeignKey(nameof(PostId))]
        public virtual Post Post { get; set; }
        public User Liker { get; set; }
        public Post LikedPost { get; set; }
    }
}
