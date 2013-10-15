using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Writer.Models
{
    public class Article
    {
        public Guid Id { get; set; }
        public string Title { get; set; }
        public string Ingress { get; set; }
        public string Text { get; set; }
        public DateTime Created { get; set; }
        public User Author { get; set; }
        public string Genre { get; set; }
    }
}