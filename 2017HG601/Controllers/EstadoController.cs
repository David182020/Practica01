using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using _2017HG601.Models;

namespace _2017HG601.Controllers
{
    [ApiController]     
    public class EstadoController : ControllerBase
    {
        private readonly ContextoAppContext _contexto;
        public EstadoController(ContextoAppContext miContexto) 
        {
            this._contexto = miContexto;
        }

        [HttpGet]
        [Route("api/ListaEstado")]
        public IEnumerable<Estado> getListadoEstado()
        {
            IEnumerable<Estado> listadoEstado = _contexto.ESTADO;
            return listadoEstado;
        }   
        /*public IActionResult Get()
        {
            var Lista = _contexto.Estado;

            if(Lista.Count > 0)
            {
                return Ok(Lista);
            }
            return NotFound();            
        } */
    }
}