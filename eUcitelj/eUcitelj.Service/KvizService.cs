using eUcitelj.Reporsitory.Common;
using eUcitelj.Service.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eUcitelj.Service
{
    public class KvizService:IKvizService
    {
        protected IKvizGenericReporsitory KvizGenericReporsitory { get; set; }

        public KvizService(IKvizGenericReporsitory kvizGenericReporsitory)
        {
            this.KvizGenericReporsitory = kvizGenericReporsitory;
        }

        public async Task<IEnumerable<IKvizDomainModel>> GetAll<IKvizDomainModel>()
        {
            return await KvizGenericReporsitory.GetAllAsync<IKvizDomainModel>();
        }

        public async Task<IKvizDomainModel> Get<IKvizDomainModel>(Guid Id)
        {
            return await KvizGenericReporsitory.GetAsync<IKvizDomainModel>(Id);
        }

        public async Task<int> Add<IKvizDomainModel>(IKvizDomainModel addObj)
        {
            return await KvizGenericReporsitory.AddAsync<IKvizDomainModel>(addObj);
        }

        public async Task<int> Update<IKvizDomainModel>(IKvizDomainModel updated)
        {
            return await KvizGenericReporsitory.UpdateAsync<IKvizDomainModel>(updated);
        }

        public async Task<int> Delete<IKvizDomainModel>(Guid Id)
        {
            return await KvizGenericReporsitory.DeleteAsync<IKvizDomainModel>(Id);
        }
    }
}
