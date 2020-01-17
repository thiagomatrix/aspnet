using System;
using System.Collections;

namespace Quicky.Dominio.Entidades
{
    public class Usuario
    {
        public int Id { get; set; }
        public string Email { get; set; }
        public string Senha { get; set; }
        public string Nome { get; set; }
        public System.Collections.Generic.ICollection<Pedido> Pedidos { get; set; } // Usuário pode ter vários pedidos

    }
   
}
