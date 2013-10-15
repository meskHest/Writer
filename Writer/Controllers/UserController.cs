using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Writer.Models;
using Writer.ViewModels;

namespace Writer.Controllers
{
    public class UserController : RavenController
    {
        //
        // GET: /User/

        public ActionResult Profile(Guid id)
        {
            User u = new User();
            u = RavenSession.Load<User>(id);

            u.Articles = RavenSession.Query<Article>().Where(x => x.Author.Id == u.Id).ToList();
            u.Poems = RavenSession.Query<Poem>().Where(x => x.Author.Id == u.Id).ToList();
            u.Comments = RavenSession.Query<Comment>().Where(x => x.Author.Id == u.Id).ToList();
            return View(u);
        }

    }
}
