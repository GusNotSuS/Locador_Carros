using LocadoraDeCarros.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LocadoraDeCarros.Database
{
    public class FakeDatabase
    {
        public List<Carro> Carros { get; } = new();
        public List<Cliente> Clientes { get; } = new();
        public List<Locacao> Locacoes { get; } = new();
    }
}

