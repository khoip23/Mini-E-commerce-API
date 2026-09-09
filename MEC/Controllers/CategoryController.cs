using MEC.Data;
using MEC.DTO;
using MEC.Models;
using Microsoft.AspNetCore.Mvc;

namespace MEC.Controllers
{
    [ApiController]
    [Route("api/category")]
    public class CategorysController : ControllerBase
    {
        private readonly MecDbContext _context;
        public CategorysController(MecDbContext context)
        {
            _context = context;
        }

        [HttpPost]
        public async Task<IActionResult> CreateCategory([FromBody] CreateCategoryDto dto)
        {
            var category = new Category
            {
                Name = dto.Name,
                Description = dto.Description
            };

            _context.Categorys.Add(category);
            await _context.SaveChangesAsync();

            return Ok(category);
        }
    }
}