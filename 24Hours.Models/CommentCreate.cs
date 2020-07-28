using _24Hours.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _24Hours.Models
{
    public class CommentCreate
    {

        [Required]
        public string Title { get; set; }
        [Required]
        public string Content { get; set; }

        public string Text { get; set; }
        
        public virtual Post CommentPost { get; set; }

        public User UserID { get; set; }

        public int Id { get; set; }

    }
}
