using LocadoraDeCarros.UI;
using LocadoraDeCarros.Services;
using Locador_Carro.UI;
using Locador_Carro.Services;
using Locador_Carro.Database;

class Program
{
    static void Main(string[] args)
    {
        // Instanciar serviços
        var carroService = new CarroService();
        var carroUI = new CarroUI();
        var locacaoUI = new LocacaoUI();

        // Instanciar ConsoleUI
        var consoleUI = new ConsoleUI(carroUI, locacaoUI);

        // Iniciar a interface principal
        consoleUI.ExibirMenu();
    }
}
