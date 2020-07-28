using _24Hours.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _24Hours.Models
{
    public class PostCreate
    {
        [Required]

        public string Title { get; set; }
        [Required]
        public string Text { get; set; }
        [Required]
        public User UserId { get; set; }
        [Required]
        public int PostId { get; set; }

        public int CommentId { get; set; }
        [Required]
        public string Content { get; set; }

    }
}
