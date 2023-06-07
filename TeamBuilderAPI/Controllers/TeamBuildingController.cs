using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using TeamBuilder.Domain.DTOs;
using TeamBuilderAPI.DTOs;
using TeamBuilderAPI.Models;

namespace TeamBuilderAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    [ApiConventionType(typeof(DefaultApiConventions))]
    public class TeamBuildingController : Controller
    {
        private ApplicationDbContext _context;
        private IMapper _mapper;

        public TeamBuildingController(ApplicationDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        [HttpPost]
        public async Task<TeamBuildingDTO> Post(TeamBuildingDTO teamBuildingDto)
        {
            var teamBuilding = _mapper.Map<TeamBuilding>(teamBuildingDto);

            _context.TeamBuildings.Add(teamBuilding);
            await _context.SaveChangesAsync();
            return teamBuildingDto;
        }

        [HttpGet]
        public List<TeamBuilding> Get()
        {
            return _context.TeamBuildings.ToList();
        }
    }
}
