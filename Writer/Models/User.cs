using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Writer.Models
{
    public class User
    {
        public Guid Id { get; set; }
        public string FirstName { get; set; }
        public string SurName { get; set; }
        public string Country { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string Description { get; set; }
        public DateTime SignedUp { get; set; }
        public Role Role { get; set; }

        public List<Article> Articles { get; set; }
        public List<Poem> Poems { get; set; }
        public List<Comment> Comments { get; set; }
    }

}