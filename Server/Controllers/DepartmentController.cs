using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using TestDeeplay.Shared.Models;
using TestDeeplay.Shared.Models.Department;
using TestDeeplay.Shared.Models.Employee;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace TestDeeplay.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DepartmentController : ControllerBase
    {
        private readonly DatabaseContext _context;
        private readonly IMapper _mapper;
        public DepartmentController(DatabaseContext databaseContext, IMapper mapper)
        {
            _context = databaseContext;
            _mapper = mapper;
        }


        // GET: api/<EmployeeController>
        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var departments = await _context.Departments.ToListAsync();
            return Ok(_mapper.Map<ICollection<DepartmentReadDto>>(departments));
        }
        [HttpGet("{id}")]
        public async Task<IActionResult> GetEmployees(int id)
        {
            var employees = await _context.Employees.Include(e => e.Department).Include(e => e.Post).Where(e => e.DepartmentId == id).ToListAsync();
            return Ok(_mapper.Map<ICollection<EmployeeReadDto>>(employees));
        }

    }
}
