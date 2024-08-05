using Fretefy.Test.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Fretefy.Test.Domain.Interfaces.Services
{
    public interface IUFService
    {
        //void AddUF(UF uf);
        //void DeleteUF(int id);
        //void UpdateUF(UF uf);
        //UF GetUFById(int id);
        IEnumerable<UF> GetAllUFs();
    }
}
