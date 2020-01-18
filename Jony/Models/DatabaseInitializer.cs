using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Jony2.Models
{
    public class DatabaseInitializer
    {
        internal static void Seed(IServiceScope scoped)
        {
            var context = scoped.ServiceProvider.GetRequiredService<AppDbContext>();
            if (!context.Menus.Any())
            {
                Menu home = new Menu
                {
                    Name = "Home",
                    ActionName = "Index",
                    ControllerName = "Home"
                };

                Menu works = new Menu
                {
                    Name = "Works",
                    ActionName = "Works",
                    ControllerName = "Home"
                };

                Menu services = new Menu
                {
                    Name = "Services",
                    ActionName = "Services",
                    ControllerName = "Home"
                };



                Menu pages = new Menu
                {
                    Name = "Pages",
                    ActionName = "Pages",
                    ControllerName = "Home"
                };



                Menu about = new Menu
                {
                    Name = "About",
                    ActionName = "About",
                    ControllerName = "Home"
                };

                Menu contact = new Menu
                {
                    Name = "Contact",
                    ActionName = "Contact",
                    ControllerName = "Home"
                };

                context.Menus.AddRange(home, works, services, pages, about, contact);
                context.SaveChanges();

                SubMenu workDetails = new SubMenu
                {
                    ActionName = "WorkDetails",
                    ControllerName = "Home",
                    Name = "Work Details",
                    MenuId = pages.Id
                };

                SubMenu elements = new SubMenu
                {
                    ActionName = "Elements",
                    ControllerName = "Home",
                    Name = "Elements",
                    MenuId = pages.Id
                };

                context.SubMenus.AddRange(workDetails, elements);
                context.SaveChanges();

               
            }
            if (!context.Services.Any())
            {
                Service service1 = new Service
                {
                    Icon = "1.svg",
                    Title = "Web & Mobile Design",
                    ShortDescription = "Sed eleifend sed nibh nec fringilla. Donec eu cursus sem vitae tristique ante ibero"
                };
                Service service2 = new Service
                {
                    Icon = "2.svg",
                    Title = "Web Development",
                    ShortDescription = "Sed eleifend sed nibh nec fringilla. Donec eu cursus sem vitae tristique ante ibero"
                };
                Service service3 = new Service
                {
                    Icon = "3.svg",
                    Title = "E-commerce",
                    ShortDescription = "Sed eleifend sed nibh nec fringilla. Donec eu cursus sem vitae tristique ante ibero"
                };
                context.Services.AddRange(service1, service2, service3);
                context.SaveChanges();
            }
        }
    }
}
