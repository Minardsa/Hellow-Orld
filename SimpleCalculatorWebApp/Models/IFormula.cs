using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleCalculatorWebApplication.Models
{
    interface IFormula
    {
        double Operand1 { get; set; }
        double Operand2 { get; set; }
        string Operator { get; set; }
    }
}
