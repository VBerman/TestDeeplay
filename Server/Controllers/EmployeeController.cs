using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using TestDeeplay.Shared.Models;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace TestDeeplay.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        private readonly DatabaseContext _context;
        public EmployeeController(DatabaseContext databaseContext)
        {
            _context = databaseContext;
        }


        // GET: api/<EmployeeController>
        [HttpGet]
        public async Task<IActionResult> Get()
        {
            return Ok(await _context.Employees.Include(e => e.Post).ThenInclude(p => p.PostInformations).Include(e => e.Department).ToListAsync());
        }

        // GET api/<EmployeeController>/5
        [HttpGet("{id}")]
        public async Task<IActionResult> Get(int id)
        {
            var findEmployee = await _context.Employees.Include(e => e.Post).ThenInclude(p => p.PostInformations).Include(e => e.Department).FirstOrDefaultAsync(e => e.Id == id);
            if (findEmployee is null)
            {
                return NotFound();
            }
            return Ok(findEmployee);
        }

        // POST api/<EmployeeController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<EmployeeController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
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
            return Ok();
        }
    }
}
