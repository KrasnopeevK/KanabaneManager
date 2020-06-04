using KanbaneManager.Entity;
using KanbaneManager.DL.Repository;
using Microsoft.AspNetCore.Mvc;

namespace KanbaneManager.WebAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class DepartmentController : BaseController<Department>
    {
        public DepartmentController(KanbaneContext kanbaneContext) : base(kanbaneContext)
        {
        }
    }
}