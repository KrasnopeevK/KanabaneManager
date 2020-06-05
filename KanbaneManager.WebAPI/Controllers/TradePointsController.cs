using KanbaneManager.Entity;
using KanbaneManager.DL.Repository;
using Microsoft.AspNetCore.Mvc;

namespace KanbaneManager.WebAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class TradePointsController : BaseController<TradePoint>
    {
        public TradePointsController(KanbaneContext context) : base(context)
        {
        }
    }
}