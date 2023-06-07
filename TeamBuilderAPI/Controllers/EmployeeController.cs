using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using TeamBuilderAPI.DTOs;
using TeamBuilderAPI.Interfaces;
using TeamBuilderAPI.Models;

namespace TeamBuilderAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    [ApiConventionType(typeof(DefaultApiConventions))]
    public class EmployeeController : Controller
    {
        private ApplicationDbContext _context;
        private IMapper _mapper;

        //private readonly ILoggerService _logger;

        public EmployeeController(ApplicationDbContext context, IMapper mapper /*ILoggerService logger*/)
        {
            _context = context;
            _mapper = mapper;
            //_logger = logger;
        }


        [HttpGet]
        public List<Employee> Get()
        {
            return _context.Employees.ToList();
        }

        [HttpGet("{id}")]
        public Employee Get(Guid id)
        {
            return _context.Employees.FirstOrDefault(x => x.Id == id);
        }

        [HttpPost]
        public async Task<EmployeeDTO> Post(EmployeeDTO employeeDto)
        {

            var employee = _mapper.Map<Employee>(employeeDto);

            //company.CompanyName= companyDto.CompanyName;
            //company.NumberOfEmployees= companyDto.NumberOfEmployees;

            _context.Employees.Add(employee);
            await _context.SaveChangesAsync();
            return employeeDto;
        }

        

            [HttpDelete("{id}")]
            public async Task<ActionResult> Delete(Guid id)
            {
                var employee = await _context.Employees.FindAsync(id);

                if (_context != null)
                {
                    _context.Employees.Remove(employee);
                }

                await _context.SaveChangesAsync();

                return Ok();
            }
        }
    } 


