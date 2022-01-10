using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using PI_Project.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace PI_Project.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            ViewData["introduction"] = "The Kozloduy Nuclear Power Plant is a nuclear power plant in Bulgaria situated 180 kilometres (110 mi) north of Sofia and 5 kilometres (3.1 mi) east of Kozloduy, a town on the Danube river, near the border with Romania. It is the country's only nuclear power plant and the largest in the region. The construction of the first reactor began on 6 April 1970.";

            ViewData["text0"] = "Kozloduy NPP currently manages two pressurized water reactors with a total gross output of 2000 MWe and 1966 MW net. Units 5 and 6, constructed in 1987 and 1991 respectively, are VVER-1000 reactors. By 2017 Unit 5 was to be upgraded to reach a capacity of 1,100 MWe, as part of a programme to extend the life of the unit by 30 years. A seventh 1,000 MW unit may be installed, using a part manufactured reactor from the terminated Belene project for which Bulgaria has paid €600m. An eighth unit is also under consideration.";

            ViewData["text1"] = "Kozloduy NPP previously operated four older reactors of the VVER-440/230 design, but under a 1993 agreement between the European Commission and the Bulgarian government, Units 1 and 2 were taken off-line at the beginning of 2004. An unpublished 1995 report by the United States Department of Energy had supposedly listed those units among the world's ten most dangerous reactors. On 21 October 2010, licenses for the shutdown reactors were transferred to Bulgaria state radioactive waste enterprise DP RAO, signaling the formal beginning of decommissioning work.";

            ViewData["text2"] = "Throughout the 1990s and early 2000s Units 3 and 4, originally licensed for operation until 2011 and 2013, respectively, underwent substantial safety improvements and, after rigorous inspections, received positive reviews from the IAEA in 2002, and from the World Association of Nuclear Operators (WANO) in the following year, concluding that no technical reasons exist for the early closure of units 3 & 4. Backed by these findings, the government had hoped to convince the European Commission to allow a postponement of the agreed pre-accession shutdown; from a legal and political standpoint, however, this proved untenable. Units 3 and 4 were taken out of operation in the final hours of 2006, immediately prior to the country's accession to the European Union.";

            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
