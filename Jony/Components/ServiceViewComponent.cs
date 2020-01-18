using Jony2.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Jony2.Components
{
    public class ServiceViewComponent:ViewComponent
    {
        private readonly AppDbContext _context;
        public ServiceViewComponent(AppDbContext context)
        {
            _context = context;
        }
        public async Task<IViewComponentResult> InvokeAsync()
        {
            return View(await _context.Services.ToListAsync());
        }
    }
}
