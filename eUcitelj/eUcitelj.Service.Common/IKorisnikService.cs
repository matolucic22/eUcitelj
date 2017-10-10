using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eUcitelj.Service.Common
{
    public interface IKorisnikService
    {
        Task<IEnumerable<IKorisnikDomainModel>> GetAll<IKorisnikDomainModel>();//task je asinkrona metoda
        Task<IKorisnikDomainModel> Get<IKorisnikDomainModel>(Guid Id);
        Task<int> Add<IKorisnikDomainModel>(IKorisnikDomainModel addObj);
        Task<int> Update<IKorisnikDomainModel>(IKorisnikDomainModel updated);
        Task<int> Delete<IKorisnikDomainModel>(Guid Id);
    }
}
