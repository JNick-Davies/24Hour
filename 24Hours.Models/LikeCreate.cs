using _24Hours.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _24Hours.Models
{
    public class LikeCreate
    {
        [Required]
       public string Title { get; set; }
        [Required]
        public string Content { get; set; }
        [Required]
        public Post LikedPost { get; set; }
        [Required]
        public User Liker { get; set; }
    }
}
