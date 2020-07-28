using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _24Hours.Data;

namespace _24Hours.Models
{
    public class UserCreate : User
    {
        [Required]
        public int CommentId { get; set; }
        [Required]
        public string Content { get; set; }
    }
}
