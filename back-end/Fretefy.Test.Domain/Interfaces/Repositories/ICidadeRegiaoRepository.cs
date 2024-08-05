using Fretefy.Test.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Fretefy.Test.Domain.Interfaces.Repositories
{
    public interface ICidadeRegiaoRepository
    {
        void AddCidadeRegiao(CidadeRegiao cidadeRegiao);
        void DeleteCidadeRegiao(int id);
        void UpdateCidadeRegiao(CidadeRegiao cidadeRegiao);
        CidadeRegiao GetCidadeRegiaoById(int id);
        IEnumerable<CidadeRegiao> GetAllCidadeRegioes();
    }
}
