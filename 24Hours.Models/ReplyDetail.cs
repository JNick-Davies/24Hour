﻿using _24Hours.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _24Hours.Models
{
    public class ReplyDetail : CommentDetail
    {
        public Comment ReplyComment { get; set; }
    }
}
