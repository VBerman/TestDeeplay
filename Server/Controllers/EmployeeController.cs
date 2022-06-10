using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using TestDeeplay.Shared.Models;
using TestDeeplay.Shared.Models.Employee;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace TestDeeplay.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        private readonly DatabaseContext _context;
        private readonly IMapper _mapper;
        public EmployeeController(DatabaseContext databaseContext, IMapper mapper)
        {
            _context = databaseContext;
            _mapper = mapper;
        }


        // GET: api/<EmployeeController>
        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var employees = await _context.Employees.Include(e => e.Department).Include(e => e.Post).ToListAsync();
            return Ok(_mapper.Map<ICollection<EmployeeReadDto>>(employees));
        }

        // GET api/<EmployeeController>/5
        [HttpGet("{id}")]
        public async Task<IActionResult> Get(int id)
        {
            var findEmployee = await _context.Employees.Include(e => e.Department).Include(e => e.Post).ThenInclude(p => p.Values).ThenInclude(v => v.Key).FirstOrDefaultAsync(e => e.Id == id);
            if (findEmployee is null)
            {
                return NotFound();
            }
            return Ok(_mapper.Map<EmployeeReadDto>(findEmployee));
        }

        [HttpGet("{departmentId}/{postId}")]
        public async Task<IActionResult> Get(int departmentId, int postId)
        {
            var employees = await _context.Employees.Include(e => e.Department).Include(e => e.Post).Where(e => e.PostId == postId & e.DepartmentId == departmentId).ToListAsync();
            return Ok(_mapper.Map<ICollection<EmployeeReadDto>>(employees));
        }

        // POST api/<EmployeeController>
        [HttpPost]
        public async Task<IActionResult> Post([FromBody] EmployeePostDto employeeDto)
        {
            try
            {
                var newEmployee = _mapper.Map<EmployeeEntity>(employeeDto);
                await _context.Employees.AddAsync(newEmployee);
                await _context.SaveChangesAsync();
                return Ok(newEmployee.Id);
            }
            catch (Exception)
            {
                return BadRequest();
            }
        }

        // PUT api/<EmployeeController>/5
        [HttpPut]
        public async Task<IActionResult> Put([FromBody] EmployeePostDto employeeDto)
        {
            try
            {
                var findedEmployee = await _context.Employees.FirstOrDefaultAsync(e => e.Id == employeeDto.Id);
                if (findedEmployee == null)
                {
                    return NotFound();
                }
                findedEmployee = _mapper.Map<EmployeeEntity>(findedEmployee);
                await _context.SaveChangesAsync();
                return Ok();

            }
            catch (Exception)
            {

                return BadRequest();
            }

        }

        // DELETE api/<EmployeeController>/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            var findEmployee = await _context.Employees.FirstOrDefaultAsync(e => e.Id == id);
            if (findEmployee is null)
            {
                return NotFound();
            }
            _context.Remove(findEmployee);
            await _context.SaveChangesAsync();
            return Ok();
        }
    }
}
