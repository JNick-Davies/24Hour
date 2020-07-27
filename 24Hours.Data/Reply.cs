using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _24Hours.Data
{
    public class Reply : Comment
    {
        [Required]
        public string ReplyComment { get; set; }
    }
}
