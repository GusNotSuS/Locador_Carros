using LocadoraDeCarros.Models;
using Locador_Carro.Models;
using LocadoraDeCarros.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LocadoraDeCarros.UI
{
    public class ConsoleUI
    {
        private readonly CrudService<Carro> _carroService;
        private readonly CrudService<Cliente> _clienteService;
        private readonly LocacaoService _locacaoService;

        public ConsoleUI(CrudService<Carro> carroService, CrudService<Cliente> clienteService, LocacaoService locacaoService)
        {
            _carroService = carroService;
            _clienteService = clienteService;
            _locacaoService = locacaoService;
        }

        public void ExibirMenu()
        {
            while (true)
            {
                Console.WriteLine("1. Gerenciar Carros");
                Console.WriteLine("2. Gerenciar Clientes");
                Console.WriteLine("3. Locar Carro");
                Console.WriteLine("4. Ver Histórico");
                Console.WriteLine("5. Sair");

                var escolha = Console.ReadLine();
                switch (escolha)
                {
                    case "1": GerenciarCarros(); break;
                    case "2": GerenciarClientes(); break;
                    case "3": LocarCarro(); break;
                    case "4": VerHistorico(); break;
                    case "5": return;
                    default: Console.WriteLine("Opção inválida."); break;
                }
            }
        }

        private void GerenciarCarros()
        {
            // Chamar métodos do CrudService para carros
        }

        private void GerenciarClientes()
        {
            // Chamar métodos do CrudService para clientes
        }

        private void LocarCarro()
        {
            // Chamar LocacaoService para locação
        }

        private void VerHistorico()
        {
            // Listar histórico de locações
        }
    }
}

