using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Client.Models
{
    public class Cliente
    {
        public string Nome { get; set;}
        public int Cpf { get; set; }
        public int Rg { get; set; }
        public string End { get; set; }

        public Cliente(string nome, int cpf , int rg, string end )
        {
            this.Nome = nome;
            this.Cpf  = cpf;
            this.Rg   = rg;
            this.End  = end;
        }

    }
}