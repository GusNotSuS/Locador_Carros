using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Locador_Carro.Models
{
    public class Carro
    {
        public int Id { get; set; } // Identificador único
        public string Modelo { get; set; }
        public string Marca { get; set; }
        public int Ano { get; set; }
        public string Placa { get; set; }
        public bool Disponivel { get; set; } // Indica se o carro está disponível para locação
        public float Valor_Diario { get; set; }
        public override string ToString()
        {
            return $"ID: {Id}, Modelo: {Modelo}, Marca: {Marca}, Ano: {Ano}, Placa: {Placa}, Disponível: {Disponivel}, Valor de diária: {Valor_Diario}";
        }
    }
}


