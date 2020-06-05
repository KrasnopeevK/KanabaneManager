using KanbaneManager.Entity;
using KanbaneManager.DL.Repository;
using Microsoft.AspNetCore.Mvc;

namespace KanbaneManager.WebAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class DepartmentsController : BaseController<Department>
    {
        public DepartmentsController(KanbaneContext kanbaneContext) : base(kanbaneContext)
        {
        }
    }
}