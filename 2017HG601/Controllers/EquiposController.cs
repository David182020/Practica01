using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using _2017HG601.Models;

namespace _2017HG601.Controllers
{
    [ApiController]     
    public class EquiposController : ControllerBase
    {
        private readonly ContextoAppContext _contexto;
        public EquiposController(ContextoAppContext miContexto) 
        {
            this._contexto = miContexto;
        }

        [HttpGet]
        [Route("api/ListaEquipos")]
        public IEnumerable<Equipos> getListadoEquipo()
        {
            IEnumerable<Equipos> listadoEquipo = _contexto.EQUIPO;
            return listadoEquipo;
        }        
        /*public IActionResult Get()
        {
            var Lista = _contexto.Equipos;

            if(Lista.Count > 0)
            {
                return Ok(Lista);
            }
            return NotFound();            
        } */
    }
}