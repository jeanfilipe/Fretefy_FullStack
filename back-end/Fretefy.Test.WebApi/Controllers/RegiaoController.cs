using Fretefy.Test.Domain.DTO;
using Fretefy.Test.Domain.Entities;
using Fretefy.Test.Domain.Interfaces.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Fretefy.Test.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RegiaoController : ControllerBase
    {
        private readonly IRegiaoService _regiaoService;

        public RegiaoController(IRegiaoService regiaoService)
        {
            _regiaoService = regiaoService;
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            var result = _regiaoService.GetAllRegioes();
            return Ok(result);
        }

        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            var result = _regiaoService.GetRegiaoById(id);
            if (result == null)
                return NotFound();
            return Ok(result);
        }

        [HttpPost]
        [Route("create")]
        public async Task<IActionResult> Create([FromBody] CreateDto regiao)
        {
            if(_regiaoService.RegiaoExiste(regiao.RegionName))
            { 
                return BadRequest("Regiao já cadastrada");
            }


            var _regiao = new Regiao() { Ativo = "Ativo", Name = regiao.RegionName };
            _regiao.CidadeRegioes = new List<CidadeRegiao>();
            foreach (var item in regiao.cities)
            {
                _regiao.CidadeRegioes.Add(new CidadeRegiao() { NomeCidade = item });
            }

            _regiaoService.AddRegiao(_regiao);
            return CreatedAtAction(nameof(GetById), new { id = _regiao.Id }, _regiao);
        }

        [HttpPut("{id}")]
        public IActionResult Update(int id, [FromBody] Regiao regiao)
        {
            if (id != regiao.Id)
                return BadRequest();

            _regiaoService.UpdateRegiao(regiao);
            return NoContent();
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            _regiaoService.DeleteRegiao(id);
            return NoContent();
        }


        [HttpPut("{id}/status/{status}")]
        public IActionResult Delete(int id, string status)
        {
            _regiaoService.StatusUpdate(id, status);
            return NoContent();

        }
    }
}
