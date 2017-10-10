using eUcitelj.Model.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eUcitelj.Service.Common
{
    public interface IOcjeneService
    {
        Task<IEnumerable<IOcjeneDomainModel>> GetAll<IOcjeneDomainModel>();
        Task<IOcjeneDomainModel> Get<IOcjeneDomainModel>(Guid Id);
        Task<int> Add<IOcjeneDomainModel>(IOcjeneDomainModel addObj);
        Task<int> Update<IOcjeneDomainModel>(IOcjeneDomainModel updated);
        Task<int> Delete<IOcjeneDomainModel>(Guid Id);
    }
}
