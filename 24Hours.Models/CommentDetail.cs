using _24Hours.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _24Hours.Models
{
    public class CommentDetail
    {
        [Required]
        public int Id { get; set; }
        [Required]
        public string Text { get; set; }
        [Required]
        public User Author { get; set; }
        [Required]
        public Post CommentPost { get; set; }
    }
}
