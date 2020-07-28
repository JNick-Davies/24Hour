using Microsoft.Exchange.WebServices.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _24Hours.Data
{
    public class Post
    {
        [Key]
        public int PostId { get; set; }
        [ForeignKey(nameof(UserId))]
        public virtual User User { get; set; }

        [Required]
        public string Title { get; set; }
        [Required]
        public string Text { get; set; }
        [ForeignKey("AuthorId")]
        public User Author { get; set; }
        public int AuthorId { get; set; }
        public DateTimeOffset CreatedUtc { get; set; }
    }
}

