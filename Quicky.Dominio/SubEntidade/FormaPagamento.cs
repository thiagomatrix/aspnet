using System;
using Quicky.Dominio.Enumerados;

namespace Quicky.Dominio.SubEntidade
{
    public class FormaPagamento
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public bool Boleto
        {
            get { return Id == (int)TipoFormaPagamentoEnun.Boleto; }
        }
        public bool CartaoCredito
        {
            get { return Id == (int)TipoFormaPagamentoEnun.CartaoCredito; }
        }
        public bool CartaoDebito
        {
            get { return Id == (int)TipoFormaPagamentoEnun.CartaoDebito; }
        }
        public bool Deposito
        {
            get { return Id == (int)TipoFormaPagamentoEnun.Deposito; }
        }
        public bool NaoDefinido
        {
            get { return Id == (int)TipoFormaPagamentoEnun.NaoDefinido; }
        }
    }
}
