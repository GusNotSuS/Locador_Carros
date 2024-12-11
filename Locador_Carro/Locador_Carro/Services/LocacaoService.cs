using LocadoraDeCarros;
using LocadoraDeCarros.Models;

public class LocacaoService
{
    public void RegistrarLocacao(Locacao locacao)
    {
        Database.Locacoes.Add(locacao);

        var carro = Database.Carros.FirstOrDefault(c => c.Id == locacao.CarroId);
        if (carro != null) carro.Disponivel = false;
    }

    public List<Locacao> ObterHistorico() => Database.Locacoes;

    public bool VerificarDisponibilidade(int carroId, DateTime dataInicio, DateTime dataFim)
    {
        return !Database.Locacoes.Any(l => l.CarroId == carroId &&
                                           l.DataLocacao < dataFim &&
                                           l.DataDevolucao > dataInicio);
    }
}




