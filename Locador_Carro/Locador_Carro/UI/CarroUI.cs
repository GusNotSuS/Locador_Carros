using Locador_Carro.Models;
using Locador_Carro.Services;
using System;

namespace Locador_Carro.UI
{
    public class CarroUI
    {
        private readonly CarroService _carroService = new CarroService();

        public void MenuCarros()
        {
            int opcao;
            do
            {
                Console.WriteLine("\n=== Menu Carros ===");
                Console.WriteLine("1. Registrar Carro");
                Console.WriteLine("2. Listar Carros Disponíveis");
                Console.WriteLine("3. Alterar Disponibilidade");
                Console.WriteLine("0. Voltar ao Menu Principal");
                Console.Write("Escolha uma opção: ");
                opcao = int.Parse(Console.ReadLine());

                switch (opcao)
                {
                    case 1:
                        RegistrarCarro();
                        break;
                    case 2:
                        ListarCarrosDisponiveis();
                        break;
                    case 3:
                        AlterarDisponibilidade();
                        break;
                }
            } while (opcao != 0);
        }

        private void RegistrarCarro()
        {
            Console.Write("Digite o modelo do carro: ");
            string modelo = Console.ReadLine();
            Console.Write("Digite a marca do carro: ");
            string marca = Console.ReadLine();
            Console.Write("Digite o ano do carro: ");
            int ano = int.Parse(Console.ReadLine());
            Console.Write("Digite a placa do carro: ");
            string placa = Console.ReadLine();

            var carro = new Carro
            {
                Id = new Random().Next(1, 1000), // Apenas para simulação
                Modelo = modelo,
                Marca = marca,
                Ano = ano,
                Placa = placa,
                Disponivel = true
            };

            _carroService.RegistrarCarro(carro);
            Console.WriteLine("Carro registrado com sucesso!");
        }

        private void ListarCarrosDisponiveis()
        {
            var carros = _carroService.ObterCarrosDisponiveis();
            Console.WriteLine("\nCarros Disponíveis:");
            foreach (var carro in carros)
            {
                Console.WriteLine(carro);
            }
        }

        private void AlterarDisponibilidade()
        {
            Console.Write("Digite o ID do carro: ");
            int id = int.Parse(Console.ReadLine());
            Console.Write("O carro está disponível? (true/false): ");
            bool disponivel = bool.Parse(Console.ReadLine());

            _carroService.AlterarDisponibilidade(id, disponivel);
            Console.WriteLine("Disponibilidade atualizada com sucesso!");
        }
    }
}
