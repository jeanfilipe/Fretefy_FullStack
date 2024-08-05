using Fretefy.Test.Domain.Entities;
using Fretefy.Test.Domain.Interfaces.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Fretefy.Test.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CidadeRegiaoController : ControllerBase
    {
        private readonly ICidadeRegiaoService _cidadeRegiaoService;

        public CidadeRegiaoController(ICidadeRegiaoService cidadeRegiaoService)
        {
            _cidadeRegiaoService = cidadeRegiaoService;
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            var result = _cidadeRegiaoService.GetAllCidadeRegioes();
            return Ok(result);
        }

        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            var result = _cidadeRegiaoService.GetCidadeRegiaoById(id);
            if (result == null)
                return NotFound();
            return Ok(result);
        }

        [HttpPost]
        public IActionResult Create([FromBody] CidadeRegiao cidadeRegiao)
        {
            _cidadeRegiaoService.AddCidadeRegiao(cidadeRegiao);
            return CreatedAtAction(nameof(GetById), new { id = cidadeRegiao.Id }, cidadeRegiao);
        }

        [HttpPut("{id}")]
        public IActionResult Update(int id, [FromBody] CidadeRegiao cidadeRegiao)
        {
            if (id != cidadeRegiao.Id)
                return BadRequest();

            _cidadeRegiaoService.UpdateCidadeRegiao(cidadeRegiao);
            return NoContent();
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            _cidadeRegiaoService.DeleteCidadeRegiao(id);
            return NoContent();
        }
    }
}
