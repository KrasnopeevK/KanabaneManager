using KanbaneManager.Entity;
using KanbaneManager.DL.Repository;
using Microsoft.AspNetCore.Mvc;

namespace KanbaneManager.WebAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class RolesController : BaseController<Role>
    {
        public RolesController(KanbaneContext context) : base(context)
        {
        }
    }
}