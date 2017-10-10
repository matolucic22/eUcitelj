using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eUcitelj.Service.Common
{
    public interface IKvizService
    {
        Task<IEnumerable<IKvizDomainModel>> GetAll<IKvizDomainModel>();//vraća IEnimerable polje podataka
        Task<IKvizDomainModel> Get<IKvizDomainModel>(Guid Id);
        Task<int> Add<IKvizDomainModel>(IKvizDomainModel addObj);
        Task<int> Update<IKvizDomainModel>(IKvizDomainModel updated);//obavi i returna samo save
        Task<int> Delete<IKvizDomainModel>(Guid Id);
    }
}
