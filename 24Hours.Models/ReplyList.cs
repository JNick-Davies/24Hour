using _24Hours.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _24Hours.Models
{
    public class ReplyList : CommentList
    {

        public Comment ReplyComment { get; set; }

        public string Title { get; set; }

    }
}
