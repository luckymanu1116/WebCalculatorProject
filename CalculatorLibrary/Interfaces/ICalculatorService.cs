using System;
using System.Collections.Generic;
using System.Text;

namespace CalculatorLibrary.Interfaces
{
    public interface ICalculatorService
    {
        double Addition(List<double> ListofValues);

        double Subtraction(List<double> ListofValues);

        double Multiplication(List<double> ListofValues);

        double Division(List<double> ListofValues);
    }
}
