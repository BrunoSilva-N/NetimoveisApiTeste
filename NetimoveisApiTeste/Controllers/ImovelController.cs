using Microsoft.AspNetCore.Mvc;
using NetimoveisApiTeste.Model;
using NetimoveisApiTeste.Repositories;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace NetimoveisApiTeste.Controllers
{
    [Route("api/[contoller]")]
    [ApiController]
    public class ImovelController:ControllerBase
    {
        private readonly IImoveisRepositor _imoveisRepositor;

        public ImovelController (IImoveisRepositor imoveisRepositor)
        {
            _imoveisRepositor = imoveisRepositor;
        }
        [HttpGet]
       public async Task<IEnumerable<Imovel>> GetImoveis()
        {
            return await _imoveisRepositor.Get();
        }
        [HttpGet("{id}")]
        public async Task<ActionResult<Imovel>> GetImoveis(int id)
        {
            return await _imoveisRepositor.Get(id);
        }
        [HttpPost]
        public async Task<ActionResult<Imovel>> PostImoveis([FromBody]Imovel imovel)
        {
            var newImovel = await _imoveisRepositor.Create(imovel);
            return imovel; 
        }
        [HttpDelete("{id}")]
        public async Task<ActionResult<Imovel>> Delete(int id)
        {
            var imovelToDelte = await _imoveisRepositor.Get(id);
               
            if (imovelToDelte == null)
                return NotFound();
            await _imoveisRepositor.Delete(imovelToDelte.id);
          return NoContent();
        }

        [HttpPut]

        public async Task<ActionResult<Imovel>> PutImovel(int id,[FromBody] Imovel imovel)
        {
            if (id != imovel.id)
                return BadRequest();
                await _imoveisRepositor.Update(imovel);
            return NoContent();    
        }
    }
}
