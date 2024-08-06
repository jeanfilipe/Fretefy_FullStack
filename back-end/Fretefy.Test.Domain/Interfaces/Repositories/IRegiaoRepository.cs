using Fretefy.Test.Domain.Entities;
using System.Collections.Generic;

namespace Fretefy.Test.Domain.Interfaces.Repositories
{
    public interface IRegiaoRepository
    {
        void AddRegiao(Regiao regiao);
        void DeleteRegiao(int id);
        void UpdateRegiao(Regiao regiao);
        Regiao GetRegiaoById(int id);
        IEnumerable<Regiao> GetAllRegioes();
        bool RegiaoExiste(string nome);
        void StatusUpdate(int id, string status);
    }
}
