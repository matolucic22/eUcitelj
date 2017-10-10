using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eUcitelj.Service.Common
{
    public interface IPredmetiService
    {
        Task<IEnumerable<IPredmetiDomainModel>> GetAll<IPredmetiDomainModel>();//vraća IEnimerable polje podataka
        Task<IPredmetiDomainModel> Get<IPredmetiDomainModel>(Guid Id);
        Task<int> Add<IPredmetiDomainModel>(IPredmetiDomainModel addObj);
        Task<int> Update<IPredmetiDomainModel>(IPredmetiDomainModel updated);//obavi i returna samo save
        Task<int> Delete<IPredmetiDomainModel>(Guid Id);
    }
}
