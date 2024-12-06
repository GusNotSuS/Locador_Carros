using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LocadoraDeCarros.Models
{
    public class Cliente
    {
        public string Nome { get; set; }
        public string CPF { get; set; } // Documento único do cliente
        public string Telefone { get; set; }

        public override string ToString()
        {
            return $"Nome: {Nome}, CPF: {CPF}, Telefone: {Telefone}";
        }
    }
}
