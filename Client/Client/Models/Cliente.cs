using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Client.Models
{
    public class Cliente
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public int Cpf { get; set; }
        public int Rg { get; set; }
        public string End { get; set; }

        public bool Equals(Object obj)
        {
            Cliente outroCliente = (Cliente)obj;
            return this.Nome == outroCliente.Nome && this.Rg == outroCliente.Rg;
        }
    }
}