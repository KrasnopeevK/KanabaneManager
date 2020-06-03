using KanbaneManager.DL.Entities;
using KanbaneManager.DL.Repository;
using Microsoft.AspNetCore.Mvc;

namespace KanbaneManager.WebAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class OrderController : BaseController<Order>
    {
        public OrderController(KanbaneContext context) : base(context)
        {
        }
    }
}