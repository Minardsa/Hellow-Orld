using SimpleCalculatorWebApplication.Models;
using SimpleCalculatorWebApplication.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;


namespace SimpleCalculatorWebApplication.Controllers
{
    public class CalculatorController : Controller
    {
        // GET: Calc
        [HttpGet]
        public ActionResult Calc()
        {
            return View();
        }

        // POST: Calc
        [HttpPost]
        public ActionResult Calc(FormCollection formCollection)
        {
            string result = string.Empty;
            
            CalculatorRepository calcRepository = new CalculatorRepository();

            // Use a FormulaModel object to pass into CalculatorRepository
            FormulaModel formulaModel = new FormulaModel();

            try
            { 
                formulaModel.Operand1 = Convert.ToDouble(formCollection["Operand1"]);
                formulaModel.Operand2 = Convert.ToDouble(formCollection["Operand2"]);
                formulaModel.Operator = formCollection["Operator"];

                ViewBag.Result = calcRepository.CalculateOperands(formulaModel);
            }
            catch (Exception e)
            { 
                Response.Write(e.InnerException);
            }

            return View();
        }

    }
}