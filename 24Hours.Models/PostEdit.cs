﻿using _24Hours.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _24Hours.Models
{
    public class PostEdit
    {
        [Required]
        public string Title { get; set; }
        [Required]
        public string Text { get; set; }
        [Required]
        public User Author { get; set; }
        [Required]
        public int PostId { get; set; }
    }
}
