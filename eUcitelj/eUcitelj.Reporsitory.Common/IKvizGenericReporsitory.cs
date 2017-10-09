using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eUcitelj.Reporsitory.Common
{
    public interface IKvizGenericReporsitory
    {
        Task<IEnumerable<IKvizDomainModel>> GetAllAsync<IKvizDomainModel>();//vraća IEnimerable polje podataka
        Task<IKvizDomainModel> GetAsync<IKvizDomainModel>(Guid Id);
        Task<int> AddAsync<IKvizDomainModel>(IKvizDomainModel addObj);
        Task<int> UpdateAsync<IKvizDomainModel>(IKvizDomainModel updated);//obavi i returna samo save
        Task<int> DeleteAsync<IKvizDomainModel>(Guid Id);
    }
}
