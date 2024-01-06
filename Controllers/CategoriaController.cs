using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using db_share.model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace db_share.Controllers
{
    [ApiController]
    [Route("api/categoria")]
    public class CategoriaController : ControllerBase
    {
        
        private readonly ModelContext Context;


        public CategoriaController(IConfiguration configuration){
            Context = new ModelContext(configuration);
        }

        [HttpPost]
        public IActionResult PostCategoria(Categoria categoria){
            Context.Add(categoria);
            if(Context.SaveChanges() == 1){
                return Ok();
            }
            return BadRequest();
        }

        [HttpGet]
        public ICollection<Categoria> GetCategorias(){
            var categorias = Context.categorias.Include(e => e.Modelos).ToList();
            return categorias;
        }

        public IActionResult UpdateCategoria(Categoria categoria){
            Context.Update(categoria);
            Context.SaveChanges();
            return Ok();
        }

        
    }
}