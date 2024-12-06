using Locador_Carro.Models;
using LocadoraDeCarros.Models;
using System;

namespace Locador_Carro.UI
{
    public class LocacaoUI
    {
        public Cliente ObterDadosCliente()
        {
            Console.WriteLine("\n=== Dados do Cliente ===");
            Console.Write("Digite o nome do cliente: ");
            string nome = Console.ReadLine();

            Console.Write("Digite o CPF do cliente: ");
            string cpf = Console.ReadLine();

            Console.Write("Digite o telefone do cliente: ");
            string telefone = Console.ReadLine();

            return new Cliente
            {
                Nome = nome,
                CPF = cpf,
                Telefone = telefone
            };
        }

        public void RealizarLocacao()
        {
            Cliente cliente = ObterDadosCliente();
            Console.WriteLine("\nInformações do cliente capturadas:");
            Console.WriteLine(cliente);
        }
    }
}

