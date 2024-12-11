using LocadoraDeCarros;

public class LocacaoUI
{
    private readonly LocacaoService _locacaoService = new();

    public void MenuLocacoes()
    {
        int opcao;
        do
        {
            Console.WriteLine("\n=== Menu Locação de Carros ===");
            Console.WriteLine("1. Realizar Locação");
            Console.WriteLine("2. Ver Histórico de Locações");
            Console.WriteLine("0. Voltar");
            Console.Write("Escolha uma opção: ");
            opcao = int.Parse(Console.ReadLine() ?? "0");

            switch (opcao)
            {
                case 1:
                    RealizarLocacao();
                    break;
                case 2:
                    VerHistorico();
                    break;
            }
        } while (opcao != 0);
    }

    private void RealizarLocacao()
    {
        Console.Write("Nome do Cliente: ");
        var nomeCliente = Console.ReadLine();
        Console.Write("CPF do Cliente: ");
        var cpfCliente = Console.ReadLine();
        Console.Write("ID do Carro: ");
        var carroId = int.Parse(Console.ReadLine() ?? "0");
        Console.Write("Data de Locação (yyyy-MM-dd): ");
        var dataInicio = DateTime.Parse(Console.ReadLine() ?? DateTime.Now.ToString());
        Console.Write("Data de Devolução (yyyy-MM-dd): ");
        var dataFim = DateTime.Parse(Console.ReadLine() ?? DateTime.Now.ToString());

        if (_locacaoService.VerificarDisponibilidade(carroId, dataInicio, dataFim))
        {
            var carro = Database.Carros.First(c => c.Id == carroId);
            var valorTotal = (float)(dataFim - dataInicio).TotalDays * carro.ValorDiario;

            _locacaoService.RegistrarLocacao(new Locacao
            {
                NomeCliente = nomeCliente,
                CpfCliente = cpfCliente,
                CarroId = carroId,
                DataLocacao = dataInicio,
                DataDevolucao = dataFim,
                ValorTotal = valorTotal
            });

            Console.WriteLine("Locação realizada com sucesso!");
        }
        else
        {
            Console.WriteLine("Carro não está disponível para o período selecionado.");
        }
    }

    private void VerHistorico()
    {
        foreach (var locacao in _locacaoService.ObterHistorico())
        {
            Console.WriteLine($"ID: {locacao.Id}, Cliente: {locacao.NomeCliente}, Carro ID: {locacao.CarroId}, Locação: {locacao.DataLocacao}, Devolução: {locacao.DataDevolucao}, Valor: {locacao.ValorTotal}");
        }
    }
}




