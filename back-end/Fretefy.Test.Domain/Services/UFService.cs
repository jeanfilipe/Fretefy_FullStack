using Fretefy.Test.Domain.Entities;
using Fretefy.Test.Domain.Interfaces.Repositories;
using Fretefy.Test.Domain.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Text;

namespace Fretefy.Test.Domain.Services
{
    public class UFService : IUFService
    {
        private readonly IUFRepository _ufRepository;

        public UFService(IUFRepository ufRepository)
        {
            _ufRepository = ufRepository;
        }

        //public UFService(IUFRepository ufRepository)
        //{
        //    _ufRepository = ufRepository;
        //}

        //public void AddUF(UF uf)
        //{
        //    _ufRepository.AddUF(uf);
        //}

        //public void DeleteUF(int id)
        //{
        //    _ufRepository.DeleteUF(id);
        //}

        //public void UpdateUF(UF uf)
        //{
        //    _ufRepository.UpdateUF(uf);
        //}

        //public UF GetUFById(int id)
        //{
        //    return _ufRepository.GetUFById(id);
        //}

        public IEnumerable<UF> GetAllUFs()
        {
            return _ufRepository.GetAll();
        }
    }
}
