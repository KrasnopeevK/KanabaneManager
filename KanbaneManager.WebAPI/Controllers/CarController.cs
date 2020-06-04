using KanbaneManager.Entity;
using KanbaneManager.DL.Repository;
using Microsoft.AspNetCore.Mvc;

namespace KanbaneManager.WebAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CarController : BaseController<Car>
    {
        public CarController(KanbaneContext context) : base(context)
        {
        }
    }
}