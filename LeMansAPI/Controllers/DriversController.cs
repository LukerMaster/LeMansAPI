using LeMansAPI.Models;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace LeMansAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DriversController : ControllerBase
    {

        private readonly ApiDbContext _context;

        public DriversController(ApiDbContext context)
        {
            _context = context;
        }

        // GET: api/<DriversController>
        [HttpGet]
        public ActionResult<IEnumerable<Driver>> Get()
        {
            return Ok(_context.Drivers.ToArray());
        }

        // GET api/<DriversController>/5
        [HttpGet("{id}")]
        public ActionResult<Driver?> Get(int id)
        {
            return _context.Drivers.Find(id);
        }

        // POST api/<DriversController>
        [HttpPost]
        public void Post([FromBody] Driver driver)
        {
            driver.Id = 0; // Prevent autoincrement errors.
            _context.Drivers.Add(driver);
            _context.SaveChanges();
        }

        // PUT api/<DriversController>/5
        [HttpPut("{id}")]
        public ActionResult Put(int id, [FromBody] Driver value)
        {
            var _driver = _context.Drivers.Find(id);

            if (_driver is not null)
            {
                _driver.FirstName = value.FirstName;
                _driver.LastName = value.LastName;

                _context.Drivers.Update(_driver);
                _context.SaveChanges();
                return NoContent();
            }
            return NotFound();
        }

        // DELETE api/<DriversController>/5
        [HttpDelete("{id}")]
        public ActionResult Delete(int id)
        {
            var _driver = _context.Drivers.Find(id);

            if (_driver is not null)
            {
                _context.Drivers.Remove(_driver);
                _context.SaveChanges();
                return NoContent();
            }

            return NotFound();
        }
    }
}
