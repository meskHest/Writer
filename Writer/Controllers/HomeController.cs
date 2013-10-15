using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Web;
using System.Web.Mvc;
using Writer.Models;
using Writer.ViewModels;


namespace Writer.Controllers
{
    public class HomeController :RavenController
    {
        //
        // GET: /Home/

        public ActionResult Index()
        {
            List<User> Top3NewUser = RavenSession.Query<User>().Take(3).OrderByDescending(x => x.SignedUp).ToList();

            // SpotLight

            List<User> AllUsers = RavenSession.Query<User>().ToList();

            Random rnd = new Random();
            var test = rnd.Next(0, AllUsers.Count());
            User SpotlightUser = (User)AllUsers[test];

            ViewBag.Top3NewUsers = Top3NewUser;
            ViewBag.Spotlight = SpotlightUser;
            return View();
        }

        public ActionResult SignUp()
        {
            return View();
        }

        [HttpPost]
        public ActionResult SignUp(UserRegisterModel user)
        {
            var u = new User{
            FirstName = user.FirstName,
            SurName=user.SurName,
            Country = user.Country,
            Password=user.Password,
            Description=user.Description,
            Email=user.Email,
            SignedUp = DateTime.Now
            };
            RavenSession.Store(u);
            RavenSession.SaveChanges();

            return View();
        }



    }
}
