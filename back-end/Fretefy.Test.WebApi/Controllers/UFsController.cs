using Fretefy.Test.Domain.Entities;
using Fretefy.Test.Domain.Interfaces.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Fretefy.Test.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UFsController : ControllerBase
    {
        private readonly IUFService _ufService;

        public UFsController(IUFService ufService)
        {
            _ufService = ufService;
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            var result = _ufService.GetAllUFs();
            return Ok(result);
        }

        //[HttpGet("{id}")]
        //public IActionResult GetById(int id)
        //{
        //    var result = _ufService.GetById(id);
        //    if (result == null)
        //        return NotFound();
        //    return Ok(result);
        //}

        //[HttpPost]
        //public IActionResult Create([FromBody] UF uf)
        //{
        //    _ufService.(uf);
        //    return CreatedAtAction(nameof(GetById), new { id = uf.Id }, uf);
        //}

        //[HttpPut("{id}")]
        //public IActionResult Update(int id, [FromBody] UF uf)
        //{
        //    if (id != uf.Id)
        //        return BadRequest();

        //    _ufService.Update(uf);
        //    return NoContent();
        //}

        //[HttpDelete("{id}")]
        //public IActionResult Delete(int id)
        //{
        //    _ufService.Delete(id);
        //    return NoContent();
        //}
    }
}
