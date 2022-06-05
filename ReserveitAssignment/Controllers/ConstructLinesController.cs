using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;

namespace ReserveitAssignment.Controllers
{
    [Route("api/[Action]")]
    [ApiController]
    public class ConstructLinesController : ControllerBase
    {

        LineConstructorRepository lineConstructorRepository = new LineConstructorRepository();

        [HttpGet]

        public IActionResult Get()
        {
            try
            {
                HttpContext.Response.Headers.Add("page-size", "{pageSize}");
                return Ok(lineConstructorRepository.GetLines());
            }catch (Exception)
            {
                return StatusCode(401);
            }

        }


        [HttpPost("{pageSize:int}")]
        public IActionResult Post(int pageSize, List<string> text)
        {
            try
            {
                HttpContext.Response.Headers.Add("page-size","{pageSize}");
                lineConstructorRepository.LineConstructorRepositiry(pageSize, text);
                return Created("~/api/page-size/"+ pageSize, text);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        
        }
    }


}
