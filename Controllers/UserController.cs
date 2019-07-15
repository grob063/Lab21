using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Lab21.Models;

namespace Lab21.Controllers
{
    public class UserController : Controller
    {
        private static DataRepo _repository = new DataRepo();

        [HttpGet]
        public IActionResult Registration(int id)
        {
            {
                var user = _repository.Get(id);
                return View(user);
            }            
        }

        [HttpPost]
        public IActionResult Registration(int id, User user)
        {
            if(!ModelState.IsValid)
            {
                return View(user);
            }

            _repository.Save(id, user);

            return RedirectToAction("Index", "Home");
        }
    }
}