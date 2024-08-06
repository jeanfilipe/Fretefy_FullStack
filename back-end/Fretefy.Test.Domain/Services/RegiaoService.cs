using Fretefy.Test.Domain.Entities;
using Fretefy.Test.Domain.Interfaces.Repositories;
using Fretefy.Test.Domain.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Text;

namespace Fretefy.Test.Domain.Services
{
    public class RegiaoService : IRegiaoService
    {
        private readonly IRegiaoRepository _regiaoRepository;

        public RegiaoService(IRegiaoRepository regiaoRepository)
        {
            _regiaoRepository = regiaoRepository;
        }

        public void AddRegiao(Regiao regiao)
        {
            _regiaoRepository.AddRegiao(regiao);
            
        }

        public void DeleteRegiao(int id)
        {
            _regiaoRepository.DeleteRegiao(id);
        }

        public void UpdateRegiao(Regiao regiao)
        {
            _regiaoRepository.UpdateRegiao(regiao);
        }

        public Regiao GetRegiaoById(int id)
        {
            return _regiaoRepository.GetRegiaoById(id);
        }

        public IEnumerable<Regiao> GetAllRegioes()
        {
            return _regiaoRepository.GetAllRegioes();
        }

        public void StatusUpdate(int id, string status)
        {
            _regiaoRepository.StatusUpdate(id, status);
        }

        public bool RegiaoExiste(string nome)
        {
            return _regiaoRepository.RegiaoExiste(nome);
        }
    }
}
