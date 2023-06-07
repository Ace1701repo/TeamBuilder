using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using TeamBuilderAPI.DTOs;
using TeamBuilderAPI.Models;

namespace TeamBuilderAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    [ApiConventionType(typeof(DefaultApiConventions))]
    public class TeamController : Controller
    {
        private ApplicationDbContext _context;
        private IMapper _mapper;

        public TeamController(ApplicationDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        [HttpGet]
        public List<Team> Get()
        {
            return _context.Teams.ToList();
        }

        [HttpGet("{id}")]
        public Team Get(Guid id)
        {
            return _context.Teams.FirstOrDefault(x => x.Id == id);
        }

        [HttpPost]
        public async Task<Team> Post(TeamDTO teamDto)
        {
            var team = _mapper.Map<Team>(teamDto);

            _context.Teams.Add(team);
            await _context.SaveChangesAsync();
            return team;
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult> Delete(Guid id)
        {
            var team = await _context.Teams.FindAsync(id);

            if (_context != null)
            {
                _context.Teams.Remove(team);
            }

            await _context.SaveChangesAsync();

            return Ok();
        }
    }
}

