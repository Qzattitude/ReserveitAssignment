﻿using Microsoft.AspNetCore.Http;
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
    public class LineConstructorController : ControllerBase
    {
        [HttpGet]
        public IActionResult Get()
        {
            var text = new List<string>() { "Music", "Love", "Money", "Food", "Game", "Bad CGPA"};
            var listToString = "";
            var minLength = 6;
            List<string> line = new List<string>();

            foreach (var item in text)
            {
                listToString = string.Join(" ", text);
            }

            

            if (!string.IsNullOrEmpty(listToString))
            {
                for (int i = 0; i < listToString.Length; i += (minLength-1))
                {
                    //line = new List<string>() { 
                    if (i + (minLength - 1) >= listToString.Length)
                    {
                        var subline = listToString.Substring(i, ((listToString.Length)-i));
                    }
                    else
                    {
                        var substring = listToString.Substring(i, (minLength - 1));
                    }
                }
            }
            
            return Ok(line);

        }

    }


}
