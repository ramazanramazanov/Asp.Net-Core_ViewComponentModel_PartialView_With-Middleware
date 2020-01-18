using Jony2.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Jony2.Components
{
    public class MenuViewComponent: ViewComponent
    {
        private readonly AppDbContext _context;
        public MenuViewComponent(AppDbContext context)
        {
            _context = context;
        }
        public async Task<IViewComponentResult> InvokeAsync()
        {
            return View(await _context.Menus.Include("SubMenus").ToListAsync());
        }
    }
}
