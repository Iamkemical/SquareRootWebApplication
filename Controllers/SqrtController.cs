using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace CSharpTaskFive.Controllers
{
    public class SqrtController : Controller
    {
       
        [HttpGet]
        public ActionResult Root()
        {
            return View();
        }
        
        [HttpPost]
        public ActionResult Root(string firstNumber, string secondNumber)
        {
            double firstNum = double.Parse(firstNumber);
            double secondNum = double.Parse(secondNumber);

            double numberOne = Math.Sqrt(firstNum);
            double numberTwo = Math.Sqrt(secondNum);
            double value;

            if (numberOne > numberTwo)
            {
                ViewBag.Result = "The number " + firstNum + " with Square root " + numberOne +
                    " has a higher square root than the number " + secondNum + " with square root " + numberTwo;
            }
            else if (numberTwo > numberOne)
            {
                ViewBag.Result = "The number " + secondNum + " with Square root " + numberTwo +
                    " has a higher square root than the number " + firstNum + " with square root " + numberOne;
            }
            else if (numberOne == numberTwo)
            {
                ViewBag.Result = "The First number and the Second number have the same root, please enter another number";
            }
            else if (firstNum <1 || secondNum <1)
            {
                ViewBag.Result = "One of the numbers you entered is a negative number, please try again";
            }
            else if (double.TryParse(firstNumber, out value))
            {
                ViewBag.Result = "The value entered on either of the box is not a number, please try again";
            }
            return View();
        }
    }
}