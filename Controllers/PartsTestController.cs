using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PI_Project.Controllers
{
    public class PartsTestController : Controller
    {

        //
        // GET: /Index/Hello
        
        //public string Index(int partNum)
        //{
         //   return "Hello part " + partNum;
       // }


        public IActionResult Index(int partID)
        {
            ViewData["PartID"] = partID;
            return View();
        }

        //public IActionResult GetPartID(int partID)
       // {

         //   ViewData["PartID"] = partID;

         //   return View();
        //}
    }
}
