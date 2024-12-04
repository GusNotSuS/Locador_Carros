using LocadoraDeCarros.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace LocadoraDeCarros.Services
{
    public class LocacaoService
    {
        private readonly List<Locacao> _locacoes = new();
        private readonly CarroService _carroService;

        public LocacaoService(CarroService carroService)
        {
            _carroService = carroService;
        }

        public void RegistrarLocacao(int carroId, int clienteId, DateTime dataInicio, decimal valorTotal)
        {
            var carro = _carroService.ObterPorId(carroId);
            if (carro == null || !carro.Disponivel)
                throw new InvalidOperationException("Carro não disponível para locação.");

            carro.Disponivel = false;

            var locacao = new Locacao
            {
                Id = _locacoes.Count > 0 ? _locacoes.Max(l => l.Id) + 1 : 1,
                CarroId = carroId,
                ClienteId = clienteId,
                DataInicio = dataInicio,
                ValorTotal = valorTotal
            };

            _locacoes.Add(locacao);
        }

        public void FinalizarLocacao(int locacaoId, DateTime dataFim)
        {
            var locacao = _locacoes.FirstOrDefault(l => l.Id == locacaoId);
            if (locacao == null)
                throw new InvalidOperationException("Locação não encontrada.");

            var carro = _carroService.ObterPorId(locacao.CarroId);
            if (carro != null)
                carro.Disponivel = true;

            locacao.DataFim = dataFim;
        }

        public List<Locacao> ObterHistorico() => _locacoes;

        public Locacao ObterPorId(int id) => _locacoes.FirstOrDefault(l => l.Id == id);
    }
}

