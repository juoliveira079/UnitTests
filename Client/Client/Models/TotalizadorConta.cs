using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Client.Models
{
    public class TotalizadorConta
    {
        public double Total { get; private set; }

        public void Acumula(Itributavel t)
        {
            Total += t.CalculaTributo();
        }
    }
}