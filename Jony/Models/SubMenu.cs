using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Jony2.Models
{
    public class SubMenu
    {
        public int Id { get; set; }
        public string Name { get; set; }

        [Required]
        public string ControllerName { get; set; }
        [Required]
        public string ActionName { get; set; }

        public int MenuId { get; set; }
        public virtual Menu Menu { get; set; }
    }
}
