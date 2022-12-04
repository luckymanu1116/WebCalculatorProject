using CalculatorLibrary.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;

namespace CalculatorLibrary
{
    public class CalculatorService : ICalculatorService
    {
        public double Result;

        public CalculatorService()
        {
            Result = 0.0;   
        }

        public double Addition(List<double> ListofValues)
        {
            try
            {

                if (ListofValues != null && ListofValues.Count > 0)
                {
                    ListofValues.ForEach(x => Result += x);
                    return Math.Round(Result, 3);
                }
                else
                    throw new NullReferenceException("Invalid inputs");                
            }
            catch(Exception ex)
            {
                throw ex;                
            }
        }

        public double Subtraction(List<double> ListofValues)
        {
            try
            {
                if (ListofValues != null && ListofValues.Count > 0)
                {
                    Result = ListofValues.FirstOrDefault();
                    ListofValues.RemoveAt(0);
                    ListofValues.ForEach(x => Result -= x);
                    return Math.Round(Result, 3);
                }
                else
                    throw new NullReferenceException("Invalid inputs");
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public double Multiplication(List<double> ListofValues)
        {
            try
            {
                if (ListofValues != null && ListofValues.Count > 0)
                {
                    Result = 1.0;
                    ListofValues.ForEach(x => Result *= x);
                    return Math.Round(Result, 3);
                }
                else
                    throw new NullReferenceException("Invalid inputs");
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public double Division(List<double> ListofValues)
        {
            try
            {
                if (ListofValues != null && ListofValues.Count > 0)
                {

                    Result = ListofValues.FirstOrDefault();
                    ListofValues.RemoveAt(0);
                    foreach (double x in ListofValues)
                    {
                        if (x == 0)
                        {
                            throw new DivideByZeroException("Invalid inputs"); 
                        }
                        else
                            Result /= x;
                    }
                    return Math.Round(Result, 3);
                }
                else
                    throw new NullReferenceException("Invalid inputs");
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
