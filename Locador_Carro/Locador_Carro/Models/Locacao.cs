using System;

namespace Locador_Carro.Models
{
    public class Locacao
    {
        public int Id { get; set; }
        public string ClienteNome { get; set; }
        public string ClienteCPF { get; set; }
        public int CarroId { get; set; }
        public DateTime DataLocacao { get; set; }
        public DateTime DataDevolucao { get; set; } // Pode ser null se ainda não devolvido
        public float valor_locacao { get; set; }
        public override string ToString()
        {
            return $"Id: {Id}, Cliente: {ClienteNome}, Id do Carro: {CarroId}" +
                   $"Data Locação: {DataLocacao}, Data Devolução: {(DataDevolucao)}";
        }
    }
}

