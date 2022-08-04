using Calculadora.Models;
using Microsoft.EntityFrameworkCore;

namespace Calculadora.Data
{
    public class BancoContext : DbContext
    {
        public BancoContext(DbContextOptions<BancoContext> options) : base(options)
        {

        }
        public DbSet<CalculadoraModel> calculadoras { get; set; }
    }
}
