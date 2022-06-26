﻿using AppRestaurant.Models;
using AppRestaurant.Repository.Repository.Implement;
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
                
        [HttpGet("{nroDocumento}/{password}")]
        public IActionResult Get(string nroDocumento, string password)
        {
            return Ok(_unit.Clientes.GetByDocumento(nroDocumento, password));
        }
    }
}