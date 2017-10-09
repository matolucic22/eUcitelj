using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eUcitelj.Reporsitory.Common
{
   public interface IOcjeneGenericReporsitory
    {
        Task<IEnumerable<IOcjeneDomainModel>> GetAllAsync<IOcjeneDomainModel>();//vraća IEnimerable polje podataka
        Task<IOcjeneDomainModel> GetAsync<IOcjeneDomainModel>(Guid Id);
        Task<int> AddAsync<IOcjeneDomainModel>(IOcjeneDomainModel addObj);
        Task<int> UpdateAsync<IOcjeneDomainModel>(IOcjeneDomainModel updated);//obavi i returna samo save
        Task<int> DeleteAsync<IOcjeneDomainModel>(Guid Id);
    }
}
