using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LocadoraDeCarros.Models
{
    public class Locacao
    {
        public int Id { get; set; }
        public int CarroId { get; set; }
        public Cliente Cliente { get; set; }
        public DateTime DataInicio { get; set; }
        public DateTime? DataFim { get; set; } // Nullable para indicar locações ainda em andamento
        public decimal ValorTotal { get; set; }

        public Locacao() { }

        public Locacao(int carroId, int clienteId, DateTime dataInicio, decimal valorTotal)
        {
            CarroId = carroId;
            DataInicio = dataInicio;
            ValorTotal = valorTotal;
        }
    }
}
