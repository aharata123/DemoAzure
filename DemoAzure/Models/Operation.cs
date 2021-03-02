using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DemoAzure.Models
{
    public class  Operation
    {
        [Display(Name = "First Number")]
        public int NumberA { get; set; }
        [Display(Name = "Second Number")]
        public int NumberB { get; set; }
        [Display(Name = "Result")]
        public int Result { get; set; }
        
    }
}
