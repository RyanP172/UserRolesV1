using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using UserRoles.Data;

namespace UserRoles.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class RoleController : Controller
    {
        private readonly MasterContext _context;

        public RoleController(MasterContext context)
        {
            _context = context;
        }
        
        // GET: Role
        [HttpGet]
        public async Task<IActionResult> Index()
        {
              return _context.AspNetRoles != null ? 
                          View(await _context.AspNetRoles.ToListAsync()) :
                          Problem("Entity set 'DataContext.AspNetRole'  is null.");
        }
    }
}