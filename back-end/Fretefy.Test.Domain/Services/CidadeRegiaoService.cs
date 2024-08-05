using Fretefy.Test.Domain.Entities;
using Fretefy.Test.Domain.Interfaces.Repositories;
using Fretefy.Test.Domain.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Text;

namespace Fretefy.Test.Domain.Services
{
    public class CidadeRegiaoService : ICidadeRegiaoService
    {
        private readonly ICidadeRegiaoRepository _cidadeRegiaoRepository;

        public CidadeRegiaoService(ICidadeRegiaoRepository cidadeRegiaoRepository)
        {
            _cidadeRegiaoRepository = cidadeRegiaoRepository;
        }

        public void AddCidadeRegiao(CidadeRegiao cidadeRegiao)
        {
            _cidadeRegiaoRepository.AddCidadeRegiao(cidadeRegiao);
        }

        public void DeleteCidadeRegiao(int id)
        {
            _cidadeRegiaoRepository.DeleteCidadeRegiao(id);
        }

        public void UpdateCidadeRegiao(CidadeRegiao cidadeRegiao)
        {
            _cidadeRegiaoRepository.UpdateCidadeRegiao(cidadeRegiao);
        }

        public CidadeRegiao GetCidadeRegiaoById(int id)
        {
            return _cidadeRegiaoRepository.GetCidadeRegiaoById(id);
        }

        public IEnumerable<CidadeRegiao> GetAllCidadeRegioes()
        {
            return _cidadeRegiaoRepository.GetAllCidadeRegioes();
        }
    }
}
