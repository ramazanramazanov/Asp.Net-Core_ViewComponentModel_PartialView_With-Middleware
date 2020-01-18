using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Jony2.Models
{
    public class Menu
    {
        public int Id { get; set; }
        [Required]
        [StringLength(maximumLength: 20, MinimumLength = 2)]
        public string Name { get; set; }

        [Required]
        public string ControllerName { get; set; }
        [Required]
        public string ActionName { get; set; }

        public virtual ICollection<SubMenu> SubMenus { get; set; }

        public Menu()
        {
            SubMenus = new HashSet<SubMenu>();
        }
    }
}
