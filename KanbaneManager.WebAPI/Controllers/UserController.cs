using KanbaneManager.Entity;
using KanbaneManager.DL.Repository;
using Microsoft.AspNetCore.Mvc;

namespace KanbaneManager.WebAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UserController : BaseController<User>
    {
        public UserController(KanbaneContext context) : base(context)
        {
        }
    }
}