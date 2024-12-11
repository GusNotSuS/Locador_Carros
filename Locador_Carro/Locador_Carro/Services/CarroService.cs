using LocadoraDeCarros;
using LocadoraDeCarros.Models;

public class CarroService
    {
        public void AdicionarCarro(Carro carro)
        {
            carro.Id = Database.Carros.Count + 1;
            Database.Carros.Add(carro);
        }

        public List<Carro> ListarCarros() => Database.Carros;

        public void AlterarDisponibilidade(int id, bool disponivel)
        {
            var carro = Database.Carros.FirstOrDefault(c => c.Id == id);
            if (carro != null) carro.Disponivel = disponivel;
        }
    }



