using Fretefy.Test.Domain.Entities;
using Fretefy.Test.Domain.Interfaces.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Fretefy.Test.Infra.EntityFramework.Repositories
{
    public class RegiaoRepository : IRegiaoRepository
    {
        private readonly AppDbContext _appDbContext;

        public RegiaoRepository(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        // INSERT
        public void AddRegiao(Regiao regiao)
        {
            _appDbContext.Regioes.Add(regiao);
            _appDbContext.SaveChanges();
        }

        // DELETE
        public void DeleteRegiao(int id)
        {
            var regiao = _appDbContext.Regioes.FirstOrDefault(r => r.Id == id);
            if (regiao != null)
            {
                _appDbContext.Regioes.Remove(regiao);
                _appDbContext.SaveChanges();
            }
        }

        // UPDATE
        public void UpdateRegiao(Regiao regiao)
        {
            var existingRegiao = _appDbContext.Regioes.FirstOrDefault(r => r.Id == regiao.Id);
            if (existingRegiao != null)
            {
                existingRegiao.Name = regiao.Name;
                _appDbContext.SaveChanges();
            }
        }

        // SELECT
        public Regiao GetRegiaoById(int id)
        {
            return _appDbContext.Regioes.FirstOrDefault(r => r.Id == id);
        }

        public IEnumerable<Regiao> GetAllRegioes()
        {
            return _appDbContext.Regioes.ToList();
        }

        public void StatusUpdate(int id, string status)
        {
            var existingRegiao = _appDbContext.Regioes.FirstOrDefault(r => r.Id == id);
            if (existingRegiao != null)
            {
                existingRegiao.Ativo = status;
                _appDbContext.SaveChanges();
            }
        }
    }
}
