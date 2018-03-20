using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
// my using statements
using System.Linq;
using weddingPlanner.Models;
using weddingPlanner.ActionFilters;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using Newtonsoft.Json;
using Microsoft.EntityFrameworkCore;

namespace weddingPlanner.Controllers
{
    public class UserController : Controller
    {
        // Entity PostGres Code First connection
        private WeddingPlannerContext _context;

        public UserController(WeddingPlannerContext context)
        {
            // Entity Framework connections
            _context = context;
        }

    }
}
