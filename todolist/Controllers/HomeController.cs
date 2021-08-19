using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using todolist.Models;

namespace todolist.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Todo()
        {

            List<todolist.Models.Todo> todo = new List<Todo>
            {
                new todolist.Models.Todo
                {
                    id=1,
                    gorevAd="09.00'da kalk.",
                    gorevIsDone=true

                },
                new todolist.Models.Todo
                {
                    id=2,
                    gorevAd="00.00'da uyu.",
                    gorevIsDone=false

                },
                new todolist.Models.Todo
                {
                    id=3,
                    gorevAd="09.30'da kahvaltı yap.",
                    gorevIsDone=true

                }
            };
            return View(todo);
        }
       
    }
}