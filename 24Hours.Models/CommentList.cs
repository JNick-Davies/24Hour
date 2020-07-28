using _24Hours.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _24Hours.Models
{
    public class CommentList
    {
        [Required]
        public string Title { get; set; }

        public int CommentId { get; set; }

        public string Text { get; set; }
        public virtual Post CommentPost { get; set; }
        public virtual User Author { get; set; }

    }
}
