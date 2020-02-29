using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Calendar_Organizer.Controllers
{
    public class UsersController : Controller
    {
        private readonly IUsersRepository repo;

        public UsersController(IUsersRepository repo)
        {
            this.repo = repo;
        }

        public IActionResult Index()
        {
            var users = repo.GetGuests();
            return View(users);
        }
    }
}