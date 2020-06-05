using KanbaneManager.Entity;
using KanbaneManager.DL.Repository;
using Microsoft.AspNetCore.Mvc;

namespace KanbaneManager.WebAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CarsController : BaseController<Car>
    {
        public CarsController(KanbaneContext context) : base(context)
        {
        }
    }
}