using System;
using System.Collections.Generic;
using System.Text;

namespace Fretefy.Test.Domain.Entities
{
    public class Regiao
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Ativo { get; set; }

        public List<CidadeRegiao> CidadeRegioes { get; set; }
    }
}
