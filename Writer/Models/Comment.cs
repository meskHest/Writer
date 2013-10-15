using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Writer.Models
{
    public class Comment
    {
        public User Author { get; set; }
        public DateTime Created { get; set; }
        public Article Commented { get; set; }
        public string Text { get; set; }
    }
}