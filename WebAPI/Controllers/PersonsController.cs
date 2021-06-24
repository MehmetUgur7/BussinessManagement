using Business.Abstract;
using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PersonsController : ControllerBase
    {
        //Loosely coupled
        //Naming convention
        //IoC Container -- Inversion of Control
        IPersonService _personService;

        public PersonsController(IPersonService personService)
        {
            _personService = personService;
        }

        [HttpGet("getall")]
        public IActionResult GetAll()
        {
            //Swagger -- Api dökümantasyonu
            //Dependency chain- 

            Thread.Sleep(1000);
            var result = _personService.GetAll();
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpGet("getbyid")]
        public IActionResult GetById(int personId)
        {
            var result = _personService.GetById(personId);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpGet("getbyposition")]
        public IActionResult GetByPosition(int positionId)
        {
            var result = _personService.GetAllByPositionId(positionId);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpPost("add")]
        public IActionResult Add(Person person)
        {
            var result = _personService.Add(person);
            if (result.Success==true)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        


    }
}
