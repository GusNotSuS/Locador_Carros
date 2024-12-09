using Locador_Carro.Database;
using Locador_Carro.Models;

namespace Locador_Carro.Services
{
    public class LocacaoService
    {
        private int _proximoId = 1;

        // Registrar uma nova locação
        public void RegistrarLocacao(string clienteNome, Carro carro, DateTime dataInicio, DateTime dataFim, decimal valorDiario)
        {
            if (!carro.Disponivel)
            {
                Console.WriteLine("O carro não está disponível para locação.");
                return;
            }

            // Calcula os dias da locação
            int diasDeLocacao = (dataFim - dataInicio).Days;
            if (diasDeLocacao <= 0)
            {
                Console.WriteLine("As datas fornecidas são inválidas.");
                return;
            }

            // Calcula o valor total da locação
            decimal valorTotal = diasDeLocacao * valorDiario;

            // Cria a locação
            var locacao = new Locacao
            {
                Id = _proximoId++,
                ClienteNome = clienteNome,
                CarroModelo = carro.Modelo,
                CarroPlaca = carro.Placa,
                DataLocacao = dataInicio,
                DataDevolucao = dataFim,
                ValorDiario = valorDiario,
                ValorTotal = valorTotal
            };

            // Adiciona ao "banco de dados"
            LocacaoDatabase.AdicionarLocacao(locacao);

            // Atualiza a disponibilidade do carro
            carro.Disponivel = false;

            Console.WriteLine($"Locação registrada com sucesso! Valor total: R${valorTotal}");
        }

        // Obter histórico de locações
        public List<Locacao> ObterHistorico()
        {
            return LocacaoDatabase.ObterHistorico();
        }
    }
}



