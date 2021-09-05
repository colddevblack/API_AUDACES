using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;



namespace APIAudaces.Controllers
{
    public class APISequenceController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public JsonResult EndPointSequence(List <int> sequence, int target)

        {
            var combination = sequence[0] + sequence[1] + sequence[2] + sequence[3];
            if (combination == target)
            {
                
                return Json(sequence);
            }

            return Json("No target");
        }
    }
}
