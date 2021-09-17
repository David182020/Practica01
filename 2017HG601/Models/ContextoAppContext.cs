using Microsoft.EntityFrameworkCore;
using _2017HG601.Models;

namespace _2017HG601
{
    public class ContextoAppContext : DbContext
    {
        //Constructor - Conexión de Base De Datos
        public ContextoAppContext(DbContextOptions<ContextoAppContext> options) : base(options)
        {
        }
        //Entidades - Modelos de Datos de equiposBD
        public DbSet<Equipos> EQUIPO { get; set; }
        public DbSet<Estado> ESTADO { get; set; }
        public DbSet<Marca> MARCA { get; set; }
        public DbSet<Tipo> TIPO { get; set; }

    }
}