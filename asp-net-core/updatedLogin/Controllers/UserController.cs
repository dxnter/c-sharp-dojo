using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using System.Linq;
using updatedLogin.Models;
using updatedLogin.ActionFilters;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using Newtonsoft.Json;
using Microsoft.EntityFrameworkCore;

namespace updatedLogin.Controllers
{
    public class UserController : Controller
    {
        private UpdatedLoginContext _context;

        public UserController(UpdatedLoginContext context)
        {
            _context = context;
        }
    }
}
