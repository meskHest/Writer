using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Writer.Models;

namespace Writer.Controllers
{
    public class TestController : RavenController
    {
        //
        // GET: /Test/

        public ActionResult getUsers()
        {

            List<User> lstu = RavenSession.Query<User>().ToList();


            return RedirectToAction("Index","Home",null);
        }

        public ActionResult deleteUsers()
        {

            List<User> lstu = RavenSession.Query<User>().ToList();
            foreach (User u in lstu)
            {
                RavenSession.Delete<User>(u);
            }

            return RedirectToAction("Index", "Home", null);
        }

        public ActionResult AddArticle()
        {

            User u = RavenSession.Query<User>().FirstOrDefault(x => x.FirstName == "Fredrik");

            Article n = new Article
            {
                Author = u,
                Title = "Hello world!",
                Ingress = "First real ravenDB test",
                Text = "Wow, it would  be neat if this worked!",
                Created = DateTime.Now
            };

            RavenSession.Store(n);
            RavenSession.SaveChanges();

            return RedirectToAction("Index", "Home", null);
        }

        public ActionResult AddPoem()
        {

            User u = RavenSession.Query<User>().FirstOrDefault(x => x.FirstName == "Fredrik");

            Poem p = new Poem
            {
                Author = u,
                Title = "My Poem",
                Text = "Wow, it would  be neat if this worked!",
                Created = DateTime.Now
            };

            RavenSession.Store(p);
            RavenSession.SaveChanges();

            return RedirectToAction("Index", "Home", null);
        }

        public ActionResult AddComment()
        {

            User u = RavenSession.Query<User>().FirstOrDefault(x => x.FirstName == "Fredrik");

            Comment c = new Comment
            {
                Author = u,
                Commented = RavenSession.Query<Article>().FirstOrDefault(x=>x.Author.Id == u.Id),
                Text = "Wow, it would  be neat if this worked!",
                Created = DateTime.Now
            };

            RavenSession.Store(c);
            RavenSession.SaveChanges();

            return RedirectToAction("Index", "Home", null);
        }

        public ActionResult deleteArticles()
        {

            User u = RavenSession.Query<User>().FirstOrDefault(x => x.FirstName == "Fredrik");

            u.Articles = RavenSession.Query<Article>().Where(x => x.Author.Id == u.Id).ToList();
            foreach (Article a in u.Articles)
            {
                RavenSession.Delete<Article>(a);
            }

            return RedirectToAction("Index", "Home", null);
        }

        

    }
}
