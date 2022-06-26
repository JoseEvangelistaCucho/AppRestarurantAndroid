﻿using AppRestaurant.Models;
using AppRestaurant.Repository.Repository.Implement;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace AppRestaurant.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RestaurantController : BaseController
    {
        public RestaurantController(IUnitOfWork unit) : base(unit)
        {
        }
                
        [HttpGet("UserLogin/{nroDocumento}/{password}")]
        public IActionResult Get(string nroDocumento, string password)
        {
            return Ok(_unit.Clientes.GetByDocumento(nroDocumento, password));
        }

        [HttpPost("UserLogin/CreateUser")]
        public IActionResult GetParameter([FromBody]Cliente cliente)
        {
            return Ok(_unit.Clientes.CreateUserCliente(cliente));
        }

        [HttpGet("id")]
        public IActionResult Get()
        {
            return Ok("CHUPETIN VAS A CAERRRR!!!!!!!");
        }


        [HttpGet("Parametro")]
        public IActionResult GetParameter(string id)
        {
            return Ok(_unit.Parametros.GetByParametro(id));
        }


        


    }
}
