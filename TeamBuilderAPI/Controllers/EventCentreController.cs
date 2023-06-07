using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using TeamBuilderAPI.DTOs;
using TeamBuilderAPI.Models;

namespace TeamBuilderAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    [ApiConventionType(typeof(DefaultApiConventions))]
    public class EventCentreController : Controller
    {
        private ApplicationDbContext _context;
        private IMapper _mapper;

        public EventCentreController(ApplicationDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        [HttpGet]
        public List<EventCentre> Get([FromQuery] int skip, [FromQuery] int take)
        {
            return _context.EventCentres.ToList();
        }

        [HttpGet("{id}")]
        public EventCentre Get(Guid id)
        {
            return _context.EventCentres.FirstOrDefault(x => x.Id == id);
        }

        [HttpPost]
        public async Task<EventCentre> Post(EventCentreDTO eventCentreDto)
        {
            var eventCentre  = _mapper.Map<EventCentre>(eventCentreDto);

            _context.EventCentres.Add(eventCentre);
            await _context.SaveChangesAsync();
            return eventCentre;
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult> Delete(Guid id)
        {
            var eventCentre = await _context.EventCentres.FindAsync(id);

            if (_context != null)
            {
                _context.EventCentres.Remove(eventCentre);
            }

            await _context.SaveChangesAsync();

            return Ok();
        }
    }
}
