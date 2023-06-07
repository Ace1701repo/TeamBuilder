using AutoMapper;
using AutoMapper.QueryableExtensions;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Identity.Client;
using TeamBuilderAPI.DTOs;
using TeamBuilderAPI.Models;

namespace TeamBuilderAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    [ApiConventionType(typeof(DefaultApiConventions))]
    public class CompanyController : Controller
    {
        private ApplicationDbContext _context;
        private IMapper _mapper;

        public CompanyController(ApplicationDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        [HttpGet]
        public List<Company> Get([FromQuery]int skip, [FromQuery]int take)
        {
            return _context.Companies.ToList();
        }

        [HttpGet("{id}")]
        public Company Get(Guid id)
        {
            return _context.Companies.FirstOrDefault(x => x.Id == id);
        }

        [HttpPost]
        public async Task<Company> Post(CompanyDTO companyDto)
        {
            //Company company = new Company();

            var company  = _mapper.Map<Company>(companyDto);

            //company.CompanyName = companyDto.CompanyName;
            //company.NumberOfEmployees = companyDto.NumberOfEmployees;

            _context.Companies.Add(company);
            await _context.SaveChangesAsync();
            return company;
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult> Delete(Guid id)
        {
            var company = await _context.Companies.FindAsync(id);

            if (_context != null)
            {
                _context.Companies.Remove(company);
            }

            await _context.SaveChangesAsync();

            return Ok();
        }

        [HttpGet("{id}/Employees")]
        public async Task<List<EmployeeDTO>> GetCompanyEmployees(Guid id)
        {
            /*var company = await _context.Companies.Include(x => x.Employees).FirstOrDefaultAsync(x => x.Id == id);
            var employees = company.Employees;

            return employees;*/

            //var employees = await _context.Employees.Where(x => x.CompanyId == id).ToListAsync();

            var employees2 = await _context.Employees
                .Where(x => x.CompanyId == id)
                .ProjectTo<EmployeeDTO>(_mapper.ConfigurationProvider).ToListAsync();

            return employees2;
        }
    }
}
