using SimpleBlog.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SimpleBlog.Controllers
{
    public class UsersController : Controller
    {
        // GET: Users
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult ListUsers()
        {
            List<UsersModel> users = new List<UsersModel>();
            users.Add(new UsersModel("Tom", "Jarky", 22, false));
            users.Add(new UsersModel("Mickle", "Jarky", 25, false));
            users.Add(new UsersModel("Jone", "Marley", 31, true));
            users.Add(new UsersModel("Alex", "Jarky", 12, false));


            return View(users);
        }
    }
}