using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Cryptography.KeyDerivation;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using updatedLogin.ActionFilters;
using updatedLogin.Models;

namespace updatedLogin.Controllers {
  public class UserController : Controller {
    private UpdatedLoginContext _context;

    public UserController(UpdatedLoginContext context) => _context = context;

    /** Register/Login GET method */
    [HttpGet]
    [Route("")]
    public IActionResult Index() {
      return View();
    }

    /** User registration POST method */
    [HttpPost]
    [Route("register")]
    public IActionResult Register(UserViewModels model) {
      if (ModelState.IsValid) {
        if (_context.Users.Any(user => String.Equals(user.Email, model.Reg.Email, StringComparison.CurrentCultureIgnoreCase))) {
          ModelState.AddModelError("Reg.Email", "An account with this email already exists");
          return View("Index");
        }
        PasswordHasher<UserViewModels> hasher = new PasswordHasher<UserViewModels>();
        string hashedPassword = hasher.HashPassword(model, model.Reg.Password);
        User newUser = new User {
          FirstName = model.Reg.FirstName,
          LastName = model.Reg.LastName,
          Email = model.Reg.Email,
          Password = hashedPassword
        };
        _context.Add(newUser);
        _context.SaveChanges();
        int id = _context.Users.Where(user => user.Email == model.Reg.Email).Select(user => user.UserId).SingleOrDefault();
        HttpContext.Session.SetInt32("id", id);
        return View("Index");
      }
      return View("Index");
    }

    /** User login POST method */
    [HttpPost]
    [Route("login")]
    public IActionResult Login(UserViewModels model) {
      if (ModelState.IsValid) {
        User matchedUser = _context.Users.SingleOrDefault(user => String.Equals(user.Email, model.Login.Email, StringComparison.CurrentCultureIgnoreCase));
        if (matchedUser == null) {
          ModelState.AddModelError("Login.Email", "Email not found");
          return View("Index");
        }
        PasswordHasher<User> hasher = new PasswordHasher<User>();

        if (hasher.VerifyHashedPassword(matchedUser, matchedUser.Password, model.Login.Password) == 0) {
          ModelState.AddModelError("Login.Password", "Incorrect password");
          return View("Index");
        }
        HttpContext.Session.SetInt32("id", matchedUser.UserId);
        return View("Index");
      }
      return View("Index");
    }

    /** User logout method */
    [HttpGet]
    [Route("logout")]
    public IActionResult Logout() {
      HttpContext.Session.Clear();
      return RedirectToAction("Index");
    }
  }
}