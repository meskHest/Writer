using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Writer.ViewModels
{
    public class UserRegisterModel
    {
        public string FirstName { get; set; }
        public string SurName { get; set; }
        public string Email { get; set; }
        public string Country { get; set; }
        public string Password { get; set; }
        public string Description { get; set; }
    }
}