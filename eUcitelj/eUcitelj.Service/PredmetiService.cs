using eUcitelj.Reporsitory.Common;
using eUcitelj.Service.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eUcitelj.Service
{
    public class PredmetiService:IPredmetiService
    {
        protected IPredmetiGenericReporsitory PredmetiGenericReporsitory { get; set; }//zove PredmetiGenericReporsitory

        public PredmetiService(IPredmetiGenericReporsitory predmetiGenericReporsitory)//povezuje sa PredmetiGenericReporsitory
        {
            this.PredmetiGenericReporsitory = predmetiGenericReporsitory;
        }


        public async Task<int> Add<IPredmetiDomainModel>(IPredmetiDomainModel addObj)
        {
            return await PredmetiGenericReporsitory.AddAsync(addObj);
        }

        public async Task<int> Delete<IPredmetiDomainModel>(Guid Id)
        {
            return await PredmetiGenericReporsitory.DeleteAsync<IPredmetiDomainModel>(Id);
        }

        public async Task<IPredmetiDomainModel> Get<IPredmetiDomainModel>(Guid Id)
        {
            return await PredmetiGenericReporsitory.GetAsync<IPredmetiDomainModel>(Id);
        }

        public async Task<IEnumerable<IPredmetiDomainModel>> GetAll<IPredmetiDomainModel>()
        {
            return await PredmetiGenericReporsitory.GetAllAsync<IPredmetiDomainModel>();
        }

        public async Task<int> Update<IPredmetiDomainModel>(IPredmetiDomainModel updated)
        {
            return await PredmetiGenericReporsitory.UpdateAsync<IPredmetiDomainModel>(updated);
        }
    }
}
