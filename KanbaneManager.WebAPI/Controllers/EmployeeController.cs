using KanbaneManager.DL.Entities;
using KanbaneManager.DL.Repository;
using Microsoft.AspNetCore.Mvc;

namespace KanbaneManager.WebAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class EmployeeController : BaseController<Employee>
    {
        public EmployeeController(KanbaneContext context) : base(context)
        {
        }
    }
}