using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using TestDeeplay.Shared.Models;
using TestDeeplay.Shared.Models.Employee;
using TestDeeplay.Shared.Models.Post;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace TestDeeplay.Server.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class PostController : ControllerBase
    {
        private readonly DatabaseContext _context;
        private readonly IMapper _mapper;
        public PostController(DatabaseContext databaseContext, IMapper mapper)
        {
            _context = databaseContext;
            _mapper = mapper;
        }


        // GET: api/<EmployeeController>
        [HttpGet]
        public async Task<IActionResult> GetShort()
        {
            var posts = await _context.Posts.ToListAsync();
            return Ok(_mapper.Map<ICollection<PostShortReadDto>>(posts));
        }
        [HttpGet("{id}")]
        public async Task<IActionResult> GetEmployees(int id)
        {
            var employees = await _context.Employees.Include(e => e.Department).Include(e => e.Post).Where(e => e.PostId == id).ToListAsync();
            return Ok(_mapper.Map<ICollection<EmployeeReadDto>>(employees));
        }

    }
}
