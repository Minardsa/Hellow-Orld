using SimpleCalculatorWebApplication.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SimpleCalculatorWebApplication.Repository
{
    public class CalculatorRepository
    {
        public string CalculateOperands(FormulaModel fm)
        {
            double result = 0.0;

            try
            {
                switch (fm.Operator)
                {
                    case "+":
                        result = fm.Operand1 + fm.Operand2;
                        break;
                    case "-":
                        result = fm.Operand1 - fm.Operand2;
                        break;
                    case "*":
                        result = fm.Operand1 * fm.Operand2;
                        break;
                    case "/":
                        result = fm.Operand1 / fm.Operand2;
                        break;
                    default:
                        break;
                }
            }
            catch (Exception e)
            {
                throw e.InnerException;
            }

            return result.ToString();
        }
    }
}