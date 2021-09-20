using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RetailSoftware_API_Jatin.Controllers
{
    public class SupplierAPIController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
