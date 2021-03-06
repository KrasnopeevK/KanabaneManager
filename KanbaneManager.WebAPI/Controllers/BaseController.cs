using System.Threading.Tasks;
using KanbaneManager.Shared.Entities;
using KanbaneManager.DL.Repository;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace KanbaneManager.WebAPI.Controllers
{
    public abstract class BaseController<T>
        where T : class, IIdentifier

    {
        private KanbaneContext _context;

        public BaseController(KanbaneContext context)
        {
            _context = context;
        }

        [Authorize]
        [HttpPost]
        public async Task<ActionResult<T>> AddEntity(T entity)
        {
            if (entity == null) return new BadRequestResult();
            await _context.Set<T>().AddAsync(entity);
            var outcome = await _context.SaveChangesAsync();
            if (outcome > 0) return new OkResult();
            return new BadRequestResult();
        }

        [Authorize]
        [HttpGet]
        public async Task<ActionResult<T>> GetAllEntity()
        {
            var entities = await _context.Set<T>().ToListAsync();
            return new OkObjectResult(entities);
        }

        [Authorize]
        [HttpGet("{id}")]
        public async Task<ActionResult<T>> GetEntity(int id)
        {
            var entity = await _context.Set<T>().FirstOrDefaultAsync(x => x.Id == id);
            if (entity == null) return new NotFoundResult();
            return new OkObjectResult(entity);
        }

        [Authorize]
        [HttpPut("{id}")]
        public async Task<ActionResult<T>> UpdateEntity(int id, T entity)
        {
            if (entity == null) return new NotFoundResult();
            entity.Id = id;
            var result = _context.Set<T>().Update(entity);
            var outcome = await _context.SaveChangesAsync();
            if (outcome > 0) return new OkResult();
            return new BadRequestResult();
        }

        [Authorize]
        [HttpDelete("{id}")]
        public async Task<ActionResult<T>> DeleteEntity(int id)
        {
            var entity = await _context.Set<T>().FirstOrDefaultAsync(x => x.Id == id);
            if (entity == null) return new NotFoundResult();
            var result = _context.Set<T>().Remove(entity);
            var outcome = await _context.SaveChangesAsync();
            if (outcome > 0) return new OkResult();
            return new BadRequestResult();
        }
    }
}