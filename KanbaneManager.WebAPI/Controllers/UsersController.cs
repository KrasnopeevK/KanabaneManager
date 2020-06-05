using KanbaneManager.Entity;
using KanbaneManager.DL.Repository;
using Microsoft.AspNetCore.Mvc;

namespace KanbaneManager.WebAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UsersController : BaseController<User>
    {
        public UsersController(KanbaneContext context) : base(context)
        {
        }
    }
}