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
    public class HomeController : Controller {
        private UpdatedLoginContext _context;

        public HomeController(UpdatedLoginContext context) => _context = context;

    }
}