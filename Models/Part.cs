using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PI_Project.Models
{
    public class Part
    {
        public int Id { get; set; }

        [StringLength(20, MinimumLength = 2)]
        [Required]
        [Display(Name = "Part name")]
        public String Part_name { get; set; }
        [Range(1, 100)]
        [Required]
        public uint Quantity { get; set; }

        [Display(Name = "Part description")]
        public String Part_desc { get; set; }
        [RegularExpression(@"^[A-Z]+[a-zA-Z0-9""'\s-]*$")]
        [StringLength(3)]
        [Required]
        [Display(Name = "Part location")]
        public String Part_loc { get; set; }
    }
}
