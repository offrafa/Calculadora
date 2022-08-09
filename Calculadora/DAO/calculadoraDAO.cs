using Calculadora.Data;
using Calculadora.Models;
using System;

namespace Calculadora.DAO
{
    public class calculadoraDAO : IcalculadoraDAO
    {
        private readonly BancoContext _bancoContext;

        public calculadoraDAO(BancoContext bancoContext)
        {
            _bancoContext = bancoContext;
        }

        public CalculadoraModel Adicionar(CalculadoraModel calculadora)
        {
            //Grava no banco de dados

            calculadora.Data = DateTime.Now;
            _bancoContext.Calculadora.Add(calculadora);
            _bancoContext.SaveChanges();
            return calculadora;

        }
    }
}
