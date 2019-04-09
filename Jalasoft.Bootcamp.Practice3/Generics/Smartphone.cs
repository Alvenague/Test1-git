using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Jalasoft.Bootcamp.Practice3.Generics
{
    [Serializable]
    public class Smartphone
    {
        [Required]
        
        [Display(Name = "Company")]
        public string Carrier { get; set; }

        [Display(Name = "Bloqued")]
        public bool IsLocked { get; set; }

        [Display(Name = "Number of contacts")]
        public int ContactCount { get; set; }

    }
}


