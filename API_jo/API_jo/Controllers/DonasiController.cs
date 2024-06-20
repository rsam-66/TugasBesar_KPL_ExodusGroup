using Microsoft.AspNetCore.Mvc;
using API_Jo.Models;
using API_Jo.TempDB;
using Microsoft.Extensions.Options;
using API_Jo.TempDB;

namespace API_Jo.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DonasiController : ControllerBase
    {
        private readonly DonasiJSON _tempdb;
        private readonly DonasiSettings _settings;

        public DonasiController(IOptions<DonasiSettings> settings)
        {
            _settings = settings.Value;
            _tempdb = new DonasiJSON(_settings.FilePath);  // Menggunakan konfigurasi file path dari settings
        }

        [HttpGet]
        public ActionResult<IEnumerable<Donasi>> ListDonasi()
        {
            return Ok(_tempdb.GetAll());
        }

        [HttpGet("{id}")]
        public ActionResult<Donasi> GetDonasi(int id)
        {
            var d = _tempdb.Get(id);
            if (d == null)
            {
                return NotFound();
            }
            return Ok(d);
        }

        [HttpPost]
        public ActionResult<Donasi> CreateDonasi(Donasi d)
        {
            var newdon = _tempdb.Add(d);
            return CreatedAtAction(nameof(GetDonasi), new { id = newdon.Id }, newdon);
        }

        [HttpPut("{id}")]
        public IActionResult UpdateDonasi(int id, Donasi d)
        {
            if (id != d.Id)
            {
                return BadRequest();
            }

            var res = _tempdb.Update(d);
            if (!res)
            {
                return NotFound();
            }

            return NoContent();
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteDonasi(int id)
        {
            var res = _tempdb.Remove(id);
            if (!res)
            {
                return NotFound();
            }

            return NoContent();
        }
    }
}
