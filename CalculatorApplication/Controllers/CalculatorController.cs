using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CalculatorApplication.Models;
using CalculatorLibrary;
using CalculatorLibrary.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CalculatorApplication.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CalculatorController : ControllerBase
    {
        private readonly ICalculatorService _calculatorService;

        public CalculatorController()
        {
            _calculatorService = new CalculatorService();
        }

        [HttpPost]
        [Route("Add")]
        public IActionResult Add(Inputs inputs)
        {
            try
            {
                return Ok(_calculatorService.Addition(inputs.ListofValues));
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return BadRequest(e.Message);
            }            
        }

        [HttpPost]
        [Route("Subtract")]
        public IActionResult Subtract(Inputs inputs)
        {
            try
            {
                return Ok(_calculatorService.Subtraction(inputs.ListofValues));
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return BadRequest(e.Message);
            }
        }

        [HttpPost]
        [Route("Multiplicate")]
        public IActionResult Multiplicate(Inputs inputs)
        {
            try
            {
                return Ok(_calculatorService.Multiplication(inputs.ListofValues));
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return BadRequest(e.Message);
            }
        }

        [HttpPost]
        [Route("Divide")]
        public IActionResult Divide(Inputs inputs)
        {
            try
            {
                return Ok(_calculatorService.Division(inputs.ListofValues));
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return BadRequest(e.Message);
            }            
        }
    }
}
