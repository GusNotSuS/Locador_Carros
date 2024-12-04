using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using LocadoraDeCarros.Models;
using System.Collections.Generic;
using System.Linq;

namespace LocadoraDeCarros.Services
{
    public class CarroService
    {
        private readonly List<Carro> _carros = new();

        public void Adicionar(Carro carro)
        {
            carro.Id = _carros.Count > 0 ? _carros.Max(c => c.Id) + 1 : 1;
            _carros.Add(carro);
        }

        public List<Carro> ObterTodos() => _carros;

        public Carro ObterPorId(int id) => _carros.FirstOrDefault(c => c.Id == id);

        public void Atualizar(int id, Carro carroAtualizado)
        {
            var carro = ObterPorId(id);
            if (carro != null)
            {
                carro.Marca = carroAtualizado.Marca;
                carro.Modelo = carroAtualizado.Modelo;
                carro.Ano = carroAtualizado.Ano;
                carro.Placa = carroAtualizado.Placa;
                carro.Disponivel = carroAtualizado.Disponivel;
            }
        }

        public void Remover(int id)
        {
            var carro = ObterPorId(id);
            if (carro != null)
            {
                _carros.Remove(carro);
            }
        }
    }
}

