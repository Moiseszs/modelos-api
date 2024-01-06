using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using db_share.model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace db_share.Controllers
{
    [ApiController]
    [Route("api/modelo")]
    public class ModeloController : ControllerBase
    {
        private readonly ModelContext Context;

        public ModeloController(IConfiguration configuration){
            Context = new ModelContext(configuration);
        }   

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Modelo>>> GetModelos(){
            var modelos = Context.modelos.Include(e => e.Categoria).ToList();

            return modelos;
        }
        
        [HttpPost]
        [Consumes("application/json")]
        public IActionResult PostModelo(Modelo modelo){
            Context.Add(modelo);
            Context.SaveChanges();  
            return Ok();
        }

        [HttpPut]
        public IActionResult UpdateModelo(Modelo modelo){
            Context.modelos.Update(modelo);
            Context.SaveChanges();
            return Ok();
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteModelo(int id){
            var modelo = Context.modelos.Find(id);
            Context.Remove(modelo);
            Context.SaveChanges();
            return Ok();
        }

        [HttpGet("{nome}")]
        public async Task<ActionResult<IEnumerable<Modelo>>> GetModelosByCategoria(string nome){
            return Context.categorias.First().Modelos.ToList();
        }
    }
}