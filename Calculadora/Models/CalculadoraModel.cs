namespace Calculadora.Models
{
    public class CalculadoraModel
    {
        public int Id { get; set; }

        public DateTime Data { get; set; }

        public int Resultado { get; set; }

        public int Historico { get; set; }
    }
}
// Criar migratiom para add Data