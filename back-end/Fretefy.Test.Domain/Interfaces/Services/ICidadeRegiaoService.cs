using Fretefy.Test.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Fretefy.Test.Domain.Interfaces.Services
{
    public interface ICidadeRegiaoService
    {
        void AddCidadeRegiao(CidadeRegiao cidadeRegiao);
        void DeleteCidadeRegiao(int id);
        void UpdateCidadeRegiao(CidadeRegiao cidadeRegiao);
        CidadeRegiao GetCidadeRegiaoById(int id);
        IEnumerable<CidadeRegiao> GetAllCidadeRegioes();
    }
}
