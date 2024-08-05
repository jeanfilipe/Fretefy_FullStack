using Fretefy.Test.Domain.Entities;
using Fretefy.Test.Domain.Interfaces.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Fretefy.Test.Infra.EntityFramework.Repositories
{
    public class CidadeRegiaoRepository : ICidadeRegiaoRepository
    {
        private readonly AppDbContext _appDbContext;

        public CidadeRegiaoRepository(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        // INSERT
        public void AddCidadeRegiao(CidadeRegiao cidadeRegiao)
        {
            _appDbContext.CidadeRegioes.Add(cidadeRegiao);
            _appDbContext.SaveChanges();
        }

        // DELETE
        public void DeleteCidadeRegiao(int id)
        {
            var cidadeRegiao = _appDbContext.CidadeRegioes.FirstOrDefault(cr => cr.Id == id);
            if (cidadeRegiao != null)
            {
                _appDbContext.CidadeRegioes.Remove(cidadeRegiao);
                _appDbContext.SaveChanges();
            }
        }

        // UPDATE
        public void UpdateCidadeRegiao(CidadeRegiao cidadeRegiao)
        {
            var existingCidadeRegiao = _appDbContext.CidadeRegioes.FirstOrDefault(cr => cr.Id == cidadeRegiao.Id);
            if (existingCidadeRegiao != null)
            {
                existingCidadeRegiao.NomeCidade = cidadeRegiao.NomeCidade;
                _appDbContext.SaveChanges();
            }
        }

        // SELECT
        public CidadeRegiao GetCidadeRegiaoById(int id)
        {
            return _appDbContext.CidadeRegioes.FirstOrDefault(cr => cr.Id == id);
        }

        public IEnumerable<CidadeRegiao> GetAllCidadeRegioes()
        {
            return _appDbContext.CidadeRegioes.ToList();
        }
    }
}
