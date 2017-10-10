using eUcitelj.Reporsitory.Common;
using eUcitelj.Service.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eUcitelj.Service
{
    public class OcjeneService:IOcjeneService
    {
        protected IOcjeneGenericReporsitory OcjeneGenericReporsitory;
        public OcjeneService(IOcjeneGenericReporsitory ocjeneGenericReporsitory)
        {
            this.OcjeneGenericReporsitory = ocjeneGenericReporsitory;
        }

        public async Task<int> Add<IOcjeneDomainModel>(IOcjeneDomainModel addObj)
        {
            return await OcjeneGenericReporsitory.AddAsync(addObj);
        }

        public async Task<int> Delete<IOcjeneDomainModel>(Guid Id)
        {
            return await OcjeneGenericReporsitory.DeleteAsync<IOcjeneGenericReporsitory>(Id);
        }

        public async Task<IOcjeneDomainModel> Get<IOcjeneDomainModel>(Guid Id)
        {
            return await OcjeneGenericReporsitory.GetAsync<IOcjeneDomainModel>(Id);
        }

        public async Task<IEnumerable<IOcjeneDomainModel>> GetAll<IOcjeneDomainModel>()
        {
            return await OcjeneGenericReporsitory.GetAllAsync<IOcjeneDomainModel>();
        }

        public async Task<int> Update<IOcjeneDomainModel>(IOcjeneDomainModel updated)
        {
            return await OcjeneGenericReporsitory.UpdateAsync<IOcjeneDomainModel>(updated);
        }
    }
}
