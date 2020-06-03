using KanbaneManager.DL.Entities;
using KanbaneManager.DL.Repository;
using Microsoft.AspNetCore.Mvc;

namespace KanbaneManager.WebAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class TradePointController : BaseController<TradePoint>
    {
        public TradePointController(KanbaneContext context) : base(context)
        {
        }
    }
}