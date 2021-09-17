using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using _2017HG601.Models;

namespace _2017HG601.Controllers
{
    [ApiController]     
    public class MarcaController : ControllerBase
    {
        private readonly ContextoAppContext _contexto;
        public MarcaController(ContextoAppContext miContexto) 
        {
            this._contexto = miContexto;
        }

        [HttpGet]
        [Route("api/ListaMarca")]
        public IEnumerable<Marca> getListadoMarca()
        {
            IEnumerable<Marca> listadoMarca = _contexto.MARCA;
            return listadoMarca;
        }   
        /*public IActionResult Ge
        /*public IActionResult Get()
        {
            var Lista = _contexto.Marca;

            if(Lista.Count > 0)
            {
                return Ok(Lista);
            }
            return NotFound();            
        } */
    }
}