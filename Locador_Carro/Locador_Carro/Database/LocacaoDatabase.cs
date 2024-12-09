using System.Collections.Generic;
using Locador_Carro.Models;
using LocadoraDeCarros.Models;

namespace Locador_Carro.Database
{
    public static class LocacaoDatabase
    {
        // Lista para armazenar o histórico de locações
        private static readonly List<Locacao> _historicoLocacoes = new List<Locacao>();

        // Adicionar uma locação ao histórico
        public static void AdicionarLocacao(Locacao locacao)
        {
            _historicoLocacoes.Add(locacao);
        }

        // Obter todas as locações do histórico
        public static List<Locacao> ObterHistorico()
        {
            return new List<Locacao>(_historicoLocacoes); // Retorna uma cópia para proteger os dados originais
        }
    }
}

