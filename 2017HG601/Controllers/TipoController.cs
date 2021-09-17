using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using _2017HG601.Models;

namespace _2017HG601.Controllers
{
    [ApiController]     
    public class TipoController : ControllerBase
    {
        private readonly ContextoAppContext _contexto;
        public TipoController(ContextoAppContext miContexto) 
        {
            this._contexto = miContexto;
        }

        [HttpGet]
        [Route("api/ListaTipo")]
        public IEnumerable<Tipo> getListadoTipo()
        {
            IEnumerable<Tipo> listadoTipo = _contexto.TIPO;
            return listadoTipo;
        }  
        /*public IActionResult Get()
        {
            var Lista = _contexto.Tipo;

            if(Lista.Count > 0)
            {
                return Ok(Lista);
            }
            return NotFound();            
        }*/ 
    }
}