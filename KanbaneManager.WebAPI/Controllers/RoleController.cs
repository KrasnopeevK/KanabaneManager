using KanbaneManager.DL.Entities;
using KanbaneManager.DL.Repository;
using Microsoft.AspNetCore.Mvc;

namespace KanbaneManager.WebAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class RoleController : BaseController<Role>
    {
        public RoleController(KanbaneContext context) : base(context)
        {
        }
    }
}