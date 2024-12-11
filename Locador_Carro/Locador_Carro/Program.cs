using System;
using LocadoraDeCarros.UI;

namespace LocadoraDeCarros
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            MenuPrincipal();
        }

        private static void MenuPrincipal()
        {
            var carroUI = new CarroUI();
            var locacaoUI = new LocacaoUI();
            int opcao;

            do
            {
                Console.WriteLine("\n=== Menu Principal ===");
                Console.WriteLine("1. Gerenciar Carros");
                Console.WriteLine("2. Gerenciar Locações");
                Console.WriteLine("0. Sair");
                Console.Write("Escolha uma opção: ");
                opcao = int.Parse(Console.ReadLine() ?? "0");

                switch (opcao)
                {
                    case 1:
                        carroUI.MenuCarros();
                        break;
                    case 2:
                        locacaoUI.MenuLocacoes();
                        break;
                    case 0:
                        Console.WriteLine("Saindo...");
                        break;
                    default:
                        Console.WriteLine("Opção inválida! Tente novamente.");
                        break;
                }
            } while (opcao != 0);
        }
    }
}
