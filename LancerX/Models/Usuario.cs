using System;
using System.Collections.Generic;
using System.Text;

namespace LancerX.Models
{
    internal class Usuario
    {
        public string Login { get; }
        public string Password { get; }
        public string NomeCompleto { get; }
        public string Cargo {  get; }
        public Usuario (string login , string password, string nomeCompleto , string cargo)
        {
            Login = login;
            Password = password;
            NomeCompleto = nomeCompleto;
            Cargo = cargo;
        }
    }
}
