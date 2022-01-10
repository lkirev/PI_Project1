using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace PI_Project.Models
{
    public class PartLocationViewModel
    {
        public List<Part> Parts { get; set; }
        public SelectList Locations { get; set; }
        public string PartLocation { get; set; }
        public string SearchString { get; set; }

    }
}
