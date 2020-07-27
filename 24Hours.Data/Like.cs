﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _24Hours.Data
{
    public class Like
    {
        [Required]
        public Post LikedPost { get; set; }
        [Required]
        public User Liker { get; set; } //who is doing the liking (alt user)
    }
}
