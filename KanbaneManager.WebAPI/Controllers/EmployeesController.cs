using KanbaneManager.Entity;
using KanbaneManager.DL.Repository;
using Microsoft.AspNetCore.Mvc;

namespace KanbaneManager.WebAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class EmployeesController : BaseController<Employee>
    {
        public EmployeesController(KanbaneContext context) : base(context)
        {
        }
    }
}