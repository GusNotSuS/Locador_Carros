using Locador_Carro.Database;
using Locador_Carro.Models;
using System.Collections.Generic;

namespace Locador_Carro.Services
{
    public class CarroService
    {
        private readonly CarroRepository _carroRepository = new CarroRepository();

        public void RegistrarCarro(Carro carro)
        {
            _carroRepository.AdicionarCarro(carro);
        }
        public Carro ObterPorId(int id)
        {
            return _carroRepository.BuscarCarroPorId(id); // Chame o método existente em CarroRepository
        }

        public List<Carro> ObterCarrosDisponiveis()
        {
            var carros = _carroRepository.ListarCarros();
            return carros.FindAll(c => c.Disponivel);
        }
        public List<Carro> ObterCarros()
        {
            var carros = _carroRepository.ListarCarros();
            return carros;
        }

        public void AlterarDisponibilidade(int id, bool disponivel)
        {
            var carro = _carroRepository.BuscarCarroPorId(id);
            if (carro != null)
            {
                carro.Disponivel = disponivel;
                _carroRepository.AtualizarCarro(carro);
            }
        }
    }
}
 

