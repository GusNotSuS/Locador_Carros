namespace LocadoraDeCarros.UI
{
    public class ConsoleUI
    {
        private readonly CarroUI _carroUI;
        private readonly LocacaoUI _locacaoUI;

        public ConsoleUI(CarroUI carroUI, LocacaoUI locacaoUI)
        {
            _carroUI = carroUI;
            _locacaoUI = locacaoUI;
        }

        public void ExibirMenu()
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("=== Sistema de Locação de Carros ===");
                Console.WriteLine("1. Gerenciar Carros");
                Console.WriteLine("2. Locar Carro");
                Console.WriteLine("3. Ver Histórico");
                Console.WriteLine("4. Sair");
                Console.Write("\nEscolha uma opção: ");

                var escolha = Console.ReadLine();

                switch (escolha)
                {
                    case "1":
                        _carroUI.MenuCarros(); // Chama o menu de gerenciamento de carros
                        break;
                    case "2":
                        _locacaoUI.MenuLocacoes(); // Chama o método para locar carro
                        break;
                    case "3":
                        VerHistorico(); // Histórico pode ser implementado aqui
                        break;
                    case "4":
                        Console.WriteLine("Encerrando o sistema...");
                        return;
                    default:
                        Console.WriteLine("Opção inválida! Pressione qualquer tecla para tentar novamente...");
                        Console.ReadKey();
                        break;
                }
            }
        }

        private void VerHistorico()
        {
            Console.WriteLine("\n=== Histórico de Locações ===");
            Console.WriteLine("Funcionalidade ainda não implementada.");
            Console.WriteLine("Pressione qualquer tecla para voltar ao menu...");
            Console.ReadKey();
        }
    }
}


