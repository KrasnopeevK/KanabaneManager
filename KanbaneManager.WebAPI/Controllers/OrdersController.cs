using KanbaneManager.Shared.Entities;
using KanbaneManager.DL.Repository;
using Microsoft.AspNetCore.Mvc;

namespace KanbaneManager.WebAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class OrdersController : BaseController<Order>
    {
        public OrdersController(KanbaneContext context) : base(context)
        {
        }
    }
}