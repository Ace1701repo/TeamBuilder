using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using TeamBuilder.DTOs;
using TeamBuilderAPI.DTOs;
using TeamBuilderAPI.Models;

namespace TeamBuilderAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    [ApiConventionType(typeof(DefaultApiConventions))]
    public class LogInController : Controller
    {
        private ApplicationDbContext _context;
        private IMapper _mapper;

        public LogInController(ApplicationDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        [HttpPost("Employee")]
        public async Task<ActionResult<EmployeeDTO>> LoginEmployee(LogInDTO loginDTO)
        {

            var employee = await _context.Employees.FirstOrDefaultAsync(x => x.UserName == loginDTO.UserName && x.Password == loginDTO.Password);

            if(employee == null)
            {
                return NotFound();
            }

            return _mapper.Map<EmployeeDTO>(employee);

        }

        [HttpPost("Company")]
        public async Task<ActionResult<CompanyDTO>> LoginCompany(CompanyLogInDTO cLoginDTO)
        {

            var company = await _context.Companies.FirstOrDefaultAsync(x => x.CompanyName == cLoginDTO.CompanyName && x.Password == cLoginDTO.Password);

            if (company == null)
            {
                return NotFound();
            }

            return _mapper.Map<CompanyDTO>(company);

        }

    }

}
