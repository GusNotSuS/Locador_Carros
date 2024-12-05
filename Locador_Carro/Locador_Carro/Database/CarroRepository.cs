using LocadoraDeCarros.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Locador_Carro.Models;
using System.Collections.Generic;

namespace Locador_Carro.Database
{
    public class CarroRepository
    {
        private readonly List<Carro> carros = new List<Carro>();

        // Adicionar carro
        public void AdicionarCarro(Carro carro)
        {
            carros.Add(carro);
        }

        // Listar carros
        public List<Carro> ListarCarros()
        {
            return carros;
        }

        // Buscar carro por ID
        public Carro BuscarCarroPorId(int id)
        {
            return carros.Find(c => c.Id == id);
        }

        // Atualizar carro
        public void AtualizarCarro(Carro carro)
        {
            var carroExistente = BuscarCarroPorId(carro.Id);
            if (carroExistente != null)
            {
                carroExistente.Modelo = carro.Modelo;
                carroExistente.Marca = carro.Marca;
                carroExistente.Ano = carro.Ano;
                carroExistente.Placa = carro.Placa;
                carroExistente.Disponivel = carro.Disponivel;
            }
        }

        // Remover carro
        public void RemoverCarro(int id)
        {
            var carro = BuscarCarroPorId(id);
            if (carro != null)
            {
                carros.Remove(carro);
            }
        }
    }
}


