using AppRestaurant.Repository.Repository.Implement;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;

namespace AppRestaurant.Controllers
{
    [Produces("application/json")]
    [ApiController]
    [EnableCors("AllowOrigin")]
    public class BaseController : ControllerBase
    {
        protected IUnitOfWork _unit;
        public BaseController(IUnitOfWork unit)
        {
            _unit = unit;
        }
    }
}
