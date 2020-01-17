using System;
namespace Quicky.Dominio.Entidades
{
    public class Pedido
    {
        public int Id { get; set; }
        public DateTime DataPedido { get; set; }
        public int UsuarioId { get; set; } // Quem está comprando
        public DateTime DataPrevisaoEntrega { get; set; }
        public string CEP { get; set; }
        public string Estado { get; set; }
        public string Cidade { get; set; }
        public string Endereco { get; set; }
        public string NumeroEndereco { get; set; }
        public string ComplementoEndereco { get; set; }
        public int FormaPagamentoId { get; set; }
        public SubEntidade.FormaPagamento FormaPagamento { get; set; }
        // Um Pedido deve ter pelo menos um item ou vários
        public System.Collections.Generic.ICollection<ItemPedido>
            ItensPedido{ get; set; }
    }
}
