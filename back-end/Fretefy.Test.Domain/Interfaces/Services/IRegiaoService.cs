using Fretefy.Test.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Fretefy.Test.Domain.Interfaces.Services
{
    public interface IRegiaoService
    {
        void AddRegiao(Regiao regiao);
        void DeleteRegiao(int id);
        void UpdateRegiao(Regiao regiao);
        Regiao GetRegiaoById(int id);
        IEnumerable<Regiao> GetAllRegioes();
        void StatusUpdate(int id, string status);
    }
}
