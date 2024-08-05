using System;
using System.Collections.Generic;
using System.Text;

namespace Fretefy.Test.Domain.Entities
{
    public class CidadeRegiao
    {
        public int Id { get; set; }
        public string NomeCidade { get; set; }
        public Regiao Regioes { get; set; }
    }
}
