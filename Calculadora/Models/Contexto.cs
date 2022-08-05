using Microsoft.EntityFrameworkCore;

namespace Calculadora.Models
{
    public class Contexto : DbContext
    {
        public Contexto(DbContextOptions<Contexto> options) : base(options)
        {

        }
        public DbSet<CalculadoraModel> calculadoras { get; set;}
    }
}
