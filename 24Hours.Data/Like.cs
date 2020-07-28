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
<<<<<<< HEAD
        public int PostId { get; set; }
        [ForeignKey(nameof(PostId))]
        public virtual Post Post { get; set; }
        public User Liker { get; set; }
=======
        public Post LikedPost { get; set; }

        [Required]
        public User Liker { get; set; } //who is doing the liking (alt user)

>>>>>>> a8bb842829de83a408996a5d0db01e59cdcb6f06
    }
}
