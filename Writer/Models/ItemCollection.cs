using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Writer.Models
{
    public class ItemCollection
    {
        public List<Article> Articles { get; set; }

        public ItemCollection()
        {
            Articles = new List<Article>();
        }
    }
}