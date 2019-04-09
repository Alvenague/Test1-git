using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jalasoft.Bootcamp.Practice3.Generics
{
    class Product
    {
        [Required]

        [Display(Name = "Name")]
        public string Name { get; set; }

    
        [Display(Name = "Price")]
        public double Price { get; set; }

    }
}
