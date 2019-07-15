using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Lab21.Models;

namespace Lab21.Controllers
{
    public class AddUserController : Controller
    {
        [HttpPost]
        public IActionResult Summary(User user)
        {
            return View();
        }
    }
}