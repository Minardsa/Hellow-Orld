using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace SimpleCalculatorWebApplication.Models
{
    public class FormulaModel : IFormula
    {
        [Display(Name = "Operand 1")]
        [Required(ErrorMessage = "The first operand is required")]
        public double Operand1 { get; set; }

        [Display(Name = "Operand 2")]
        [Required(ErrorMessage = "The second operand is required")]
        public double Operand2 { get; set; }

        [Required(ErrorMessage = "The operator is required")]
        public string Operator { get; set; }
    }
}