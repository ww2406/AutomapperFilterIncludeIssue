﻿using System.Collections.Generic;

namespace AutomapperProjectInclude.Models
{
    public class Blog
    {
        public int Id { get; set; }
        public List<Post> Posts { get; set; }
    }
}