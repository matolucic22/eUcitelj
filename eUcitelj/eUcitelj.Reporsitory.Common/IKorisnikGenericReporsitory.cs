using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eUcitelj.Reporsitory.Common
{
    public interface IKorisnikGenericReporsitory
    {
        Task<IEnumerable<IKorisnikDomainModel>> GetAllAsync<IKorisnikDomainModel>();
        Task<IKorisnikDomainModel> GetAsync<IKorisnikDomainModel>(Guid Id);
        Task<int> AddAsync<IKorisnikDomainModel>(IKorisnikDomainModel addObj);
        Task<int> UpdateAsync<IKorisnikDomainModel>(IKorisnikDomainModel updated);
        Task<int> DeleteAsync<IKorisnikDomainModel>(Guid Id);
    }
}
