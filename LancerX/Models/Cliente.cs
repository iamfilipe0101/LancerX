using System;
using System.Collections.Generic;
using System.Text;

namespace LancerX.Models
{
    internal class Cliente
    {
        public string Codigo { get; set; }
        public string Nome {  get; set; }
        public string Telefone { get; set; }
        public string Email { get; set; }

        public Cliente(string codigo,  string nome, string telefone, string email)
        {
            Codigo = codigo;
            Nome = nome;
            Telefone = telefone;
            Email = email;
        }
    }
}
