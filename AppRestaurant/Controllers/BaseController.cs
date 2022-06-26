using AppRestaurant.Repository.Repository.Implement;
using Microsoft.AspNetCore.Mvc;

namespace AppRestaurant.Controllers
{
    public class BaseController : ControllerBase
    {
        protected IUnitOfWork _unit;
        public BaseController(IUnitOfWork unit)
        {
            _unit = unit;
        }
    }
}
