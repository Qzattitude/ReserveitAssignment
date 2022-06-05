using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;

namespace ReserveitAssignment.Controllers
{
    [Route("api/[controller]")]
    [ApiController]

    public class ConstructLinesController : ControllerBase
    {

        LineConstructorRepository lineConstructorRepository = new LineConstructorRepository();

        [HttpGet]
        public IActionResult Get()
        {
            try
            {
                return Ok(lineConstructorRepository.GetLines());
            }catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }

        }


        [HttpPost]
        public IActionResult Post(int n, List<string> text)
        {
            try
            {
                lineConstructorRepository.LineConstructorRepositiry(n, text);
                return Ok(StatusCodes.Status201Created);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        
        }

        //public ArrayList ConstructLine(int minLength, List<string> text)
        //{
        //    //var text = new List<string>() { "Music", "Love", "Money", "Food", "Game", "Bad CGPA" };
        //    ArrayList line = new ArrayList();
        //    var lineOfSize = "";

        //    for (var i = 0; i < text.Count; i++)
        //    {
        //        lineOfSize = text[i];
        //        if (minLength == text[i].Length)
        //        {
        //            line.Add(text[i]);
        //        }
        //        else if (minLength > text[i].Length)
        //        {
        //            var vacant = minLength - text[i].Length;

        //            for (var j = i + 1; j < text.Count; j++)
        //            {
        //                if (text[j].Length == vacant)
        //                {
        //                    //operation
        //                    ///lineOfSize = String.Concat(lineOfSize, text[j]);
        //                    var temp = String.Concat(lineOfSize, " ");
        //                    line.Add(String.Concat(temp, text[j]));
        //                    temp = "";
        //                }
        //                else if (text[j].Length < vacant)
        //                {
        //                    //operation
        //                    //lineOfSize = String.Concat(lineOfSize, text[j]);
        //                    var temp2 = String.Concat(lineOfSize, " ");
        //                    line.Add(String.Concat(temp2, text[j]));
        //                    temp2 = "";
        //                }
        //            }

        //        }


        //    }
        //    return line;
        //}

    }


}
