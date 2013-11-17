using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace IS445.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Home/

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult FormatPhoneNumber(string inputNumber)
        {

          if (string.IsNullOrEmpty(inputNumber))
          {
            return Content("invalid input, please try again");
          }
          else if (inputNumber.Length != 10 )
          {
              return Content("Please input a 10 Digit phone number");
              }
          else
            {

              string formatted = formatNumber(inputNumber);
              return View((object)formatted);
          }
        }

        // please implement your phone number formatting logic here
        private string formatNumber(string inputNumber)
        {

            var first = inputNumber.Substring(0, 3);
            var second = inputNumber.Substring(3, 3);
            var third = inputNumber.Substring(6, 4);


          // imiplement formatting here
            return "(" + first + ") " + second + "-" + third;
        }


        public ActionResult Tasktwo()
        {
            return View();
        }

        public ActionResult phasereverse(string phase)
        {

            string[] parts = phase.Split(' ');

            string rev = "";

            foreach (string part in parts)
            {
                rev = part + " " + rev;
            }

                 
            return View((object)rev);
        }

    }
}
