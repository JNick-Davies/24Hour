using _24Hours.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _24Hours.Models
{
    public class CommentEdit
    {
        [Required]
        public string Text { get; set; }
        
        public virtual Post CommentPost { get; set; }
        [Required]
        public virtual User Author { get; set; }

        public int Id { get; set; }
    }
}
