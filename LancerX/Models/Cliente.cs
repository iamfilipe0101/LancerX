using System;
using System.Collections.Generic;
using System.Text;

namespace LancerX.Models
{
    internal class Cliente
    {
        public string Nome {  get; set; }
        public string Cpf { get; set; }
        public string Cnh { get; set; }
        public string Telefone { get; set; }
        public string Email { get; set; }
        public string Endereco { get; set; }

        public Cliente(string nome,  string cpf,string cnh, string telefone, string email, string endereco)
        {
            Nome = nome;
            Cpf = cpf;
            Cnh = cnh;
            Telefone = telefone;
            Email = email;
            Endereco = endereco;
        }
    }
}
