using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

    public class Locacao
    {
        public int Id { get; set; }
        public string NomeCliente { get; set; }
        public string CpfCliente { get; set; }
        public int CarroId { get; set; }
        public DateTime DataLocacao { get; set; }
        public DateTime DataDevolucao { get; set; }
        public float ValorTotal { get; set; }
    }