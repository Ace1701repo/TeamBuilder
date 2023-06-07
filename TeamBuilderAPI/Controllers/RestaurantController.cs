using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using TeamBuilderAPI.DTOs;
using TeamBuilderAPI.Models;

namespace TeamBuilderAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    [ApiConventionType(typeof(DefaultApiConventions))]
    public class RestaurantController : Controller
    {
        private ApplicationDbContext _context;
        private IMapper _mapper;

        public RestaurantController(ApplicationDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        [HttpGet]
        public List<Restaurant> Get([FromQuery] int skip, [FromQuery] int take)
        {
            return _context.Restaurants.ToList();
        }

        [HttpGet("{id}")]
        public Restaurant Get(Guid id)
        {
            return _context.Restaurants.FirstOrDefault(x => x.Id == id);
        }

        [HttpPost]
        public async Task<Restaurant> Post(RestaurantDTO restaurantDto)
        {
            var restaurant = _mapper.Map<Restaurant>(restaurantDto);

            _context.Restaurants.Add(restaurant);
            await _context.SaveChangesAsync();
            return restaurant;
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult> Delete(Guid id)
        {
            var restaurant = await _context.Restaurants.FindAsync(id);

            if (_context != null)
            {
                _context.Restaurants.Remove(restaurant);
            }

            await _context.SaveChangesAsync();

            return Ok();
        }
    }
}

