using LocadoraDeCarros.Models;

public class CarroUI
{
    private readonly CarroService _carroService = new();

    public void MenuCarros()
    {
        int opcao;
        do
        {
            Console.WriteLine("\n=== Menu Gerenciamento de Carros ===");
            Console.WriteLine("1. Adicionar Carro");
            Console.WriteLine("2. Listar Carros");
            Console.WriteLine("3. Alterar Disponibilidade");
            Console.WriteLine("0. Voltar");
            Console.Write("Escolha uma opção: ");
            opcao = int.Parse(Console.ReadLine() ?? "0");

            switch (opcao)
            {
                case 1:
                    AdicionarCarro();
                    break;
                case 2:
                    ListarCarros();
                    break;
                case 3:
                    AlterarDisponibilidade();
                    break;
            }
        } while (opcao != 0);
    }

    private void AdicionarCarro()
    {
        Console.Write("Modelo: ");
        var modelo = Console.ReadLine();
        Console.Write("Placa: ");
        var placa = Console.ReadLine();
        Console.Write("Marca: ");
        var marca = Console.ReadLine();
        Console.Write("Ano: ");
        var ano = int.Parse(Console.ReadLine() ?? "0");
        Console.Write("Valor Diário: ");
        var valor = float.Parse(Console.ReadLine() ?? "0");

        _carroService.AdicionarCarro(new Carro { Modelo = modelo, Placa = placa, Marca = marca, Ano = ano, ValorDiario = valor });
        Console.WriteLine("Carro adicionado com sucesso!");
    }

    private void ListarCarros()
    {
        foreach (var carro in _carroService.ListarCarros())
        {
            Console.WriteLine($"ID: {carro.Id}, Modelo: {carro.Modelo}, Disponível: {carro.Disponivel}");
        }
    }

    private void AlterarDisponibilidade()
    {
        Console.Write("ID do Carro: ");
        var id = int.Parse(Console.ReadLine() ?? "0");
        Console.Write("Disponível (true/false): ");
        var disponivel = bool.Parse(Console.ReadLine() ?? "false");

        _carroService.AlterarDisponibilidade(id, disponivel);
        Console.WriteLine("Disponibilidade alterada com sucesso!");
    }
}