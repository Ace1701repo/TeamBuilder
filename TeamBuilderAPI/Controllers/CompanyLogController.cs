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
    public class CompanyLogController : Controller
    {
        private ApplicationDbContext _context;
        private IMapper _mapper;

        public CompanyLogController(ApplicationDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        [HttpPost]
        public async Task<ActionResult<CompanyDTO>> Post(CompanyLogInDTO companyLogInDTO)
        {

            var company = await _context.Companies.FirstOrDefaultAsync(x => x.CompanyName == companyLogInDTO.CompanyName && x.Password == companyLogInDTO.Password);

            if (company == null)
            {
                return NotFound();
            }

            return _mapper.Map<CompanyDTO>(company);

        }

    }
}
