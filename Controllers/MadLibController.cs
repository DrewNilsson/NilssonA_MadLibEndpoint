// Andrew Nilsson
// 10/26/22
// MadLib - Endpoint
// This is a webapi that returns a madlib story
// Peer Review by: Marcel R. The program ran perfect. Took 10 inputs and output them in a story. Solid Work! :D


using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace NilssonA_MadLibEndpoint.Controllers
{
    [Route("[controller]")]
    public class MadLibController : Controller
    {
        [HttpGet]
        [Route("Story/{one}/{two}/{three}/{four}/{five}/{six}/{seven}/{eight}/{nine}/{ten}")]
        public string Story(string one, string two, string three, string four, string five, string six, string seven, string eight, string nine, string ten)
        {
            return $"{one} was {two} at {three} where they came across a {four} {five}. "
                    + $"Inside was {six} who threw a {seven} at {one} then raced off. {one} "
                    + $"{eight} after the car but they ran into a {nine} {ten}.";
        }
    }
}