using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eUcitelj.Reporsitory.Common
{
   public interface IPredmetiGenericReporsitory
    {
        Task<IEnumerable<IPredmetiDomainModel>> GetAllAsync<IPredmetiDomainModel>();//vraća IEnimerable polje podataka
        Task<IPredmetiDomainModel> GetAsync<IPredmetiDomainModel>(Guid Id);
        Task<int> AddAsync<IPredmetiDomainModel>(IPredmetiDomainModel addObj);
        Task<int> UpdateAsync<IPredmetiDomainModel>(IPredmetiDomainModel updated);//obavi i returna samo save
        Task<int> DeleteAsync<IPredmetiDomainModel>(Guid Id);
    }
}
