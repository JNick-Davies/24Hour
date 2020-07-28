using _24Hours.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _24Hours.Models
{
    public class CommentList
    {
        public int Id { get; set; }
        public string Text { get; set; }
        public virtual Post CommentPost { get; set; }
        public virtual User Author { get; set; }
    }
}
