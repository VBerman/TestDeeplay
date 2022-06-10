﻿using AutoMapper;
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
            var employees = await _context.Employees.Include(e => e.Department).Include(e => e.Post).ThenInclude(p => p.Values).ThenInclude(v => v.Key).ToListAsync();
            return Ok(_mapper.Map<ICollection<EmployeeReadDto>>(employees));
        }

        // GET api/<EmployeeController>/5
        [HttpGet("{id}")]
        public async Task<IActionResult> Get(int id)
        {
            var findEmployee = await _context.Employees.Include(e => e.Post).Include(e => e.Department).FirstOrDefaultAsync(e => e.Id == id);
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
