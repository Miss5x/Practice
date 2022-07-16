using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication
{
    public class InputDataModel
    {
        [Required]
        public int lenght_kod { get; set; }
        [Required]
        public int lenght_salt { get; set; }
    }
}
