using Locador_Carro.Models;
using Locador_Carro.Services;
using System;
using System.Linq;

namespace Locador_Carro.UI
{
    public class LocacaoUI
    {
        private readonly LocacaoService _locacaoService;
        private readonly CarroService _carroService;

        public LocacaoUI(LocacaoService locacaoService, CarroService carroService)
        {
            _locacaoService = locacaoService;
            _carroService = carroService;
        }

        public void MenuLocacao()
        {
            int opcao;
            do
            {
                Console.WriteLine("\n=== Menu Locação ===");
                Console.WriteLine("1. Realizar Locação");
                Console.WriteLine("2. Visualizar Histórico de Locações");
                Console.WriteLine("0. Voltar ao Menu Principal");
                Console.Write("Escolha uma opção: ");
                opcao = int.Parse(Console.ReadLine());

                switch (opcao)
                {
                    case 1:
                        RealizarLocacao();
                        break;
                    case 2:
                        VisualizarHistorico();
                        break;
                }
            } while (opcao != 0);
        }

        private void RealizarLocacao()
        {
            Console.Write("Digite o nome do cliente: ");
            string clienteNome = Console.ReadLine();

            var carrosDisponiveis = _carroService.ObterCarrosDisponiveis();
            if (!carrosDisponiveis.Any())
            {
                Console.WriteLine("Nenhum carro disponível para locação.");
                return;
            }

            Console.WriteLine("\nCarros Disponíveis:");
            foreach (var carro in carrosDisponiveis)
            {
                Console.WriteLine(carro);
            }

            Console.Write("Digite o ID do carro que deseja locar: ");
            int carroId = int.Parse(Console.ReadLine());
            var carroSelecionado = carrosDisponiveis.FirstOrDefault(c => c.Id == carroId);

            if (carroSelecionado == null)
            {
                Console.WriteLine("Carro não encontrado.");
                return;
            }

            Console.Write("Digite a data de início da locação (formato: yyyy-MM-dd): ");
            DateTime dataInicio = DateTime.Parse(Console.ReadLine());

            Console.Write("Digite a data de fim da locação (formato: yyyy-MM-dd): ");
            DateTime dataFim = DateTime.Parse(Console.ReadLine());

            Console.Write("Digite o valor diário da locação: R$");
            decimal valorDiario = decimal.Parse(Console.ReadLine());

            _locacaoService.RegistrarLocacao(clienteNome, carroSelecionado, dataInicio, dataFim, valorDiario);
        }

        private void VisualizarHistorico()
        {
            var historico = _locacaoService.ObterHistorico();

            if (!historico.Any())
            {
                Console.WriteLine("Nenhuma locação registrada.");
                return;
            }

            Console.WriteLine("\nHistórico de Locações:");
            foreach (var locacao in historico)
            {
                Console.WriteLine(locacao);
            }
        }
    }
}


