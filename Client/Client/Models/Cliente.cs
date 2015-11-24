using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Client.Models
{
    public class Cliente
    {
        public int Id { get; set; }
        public string Nome { get; set;}
        public int Cpf { get; set; }
        public int Rg { get; set; }
        public string End { get; set; }

    }
}