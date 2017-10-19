using eUcitelj.Reporsitory.Common;
using eUcitelj.Service.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eUcitelj.Service
{
    public class KorisnikService : IKorisnikService
    {
        protected IKorisnikGenericReporsitory KorisnikGenericReporsitory { set; get; }
        public KorisnikService(IKorisnikGenericReporsitory korisnikGenericReporsitory)
        {
            this.KorisnikGenericReporsitory = korisnikGenericReporsitory;
        }
        public async Task<int> Add<IKorisnikDomainModel>(IKorisnikDomainModel addObj)
        {
           return await KorisnikGenericReporsitory.AddAsync<IKorisnikDomainModel>(addObj);
        }

        public async Task<int> Delete<IKorisnikDomainModel>(Guid Id)
        {
            return await KorisnikGenericReporsitory.DeleteAsync<IKorisnikDomainModel>(Id);
        }

        public async Task<IKorisnikDomainModel> Get<IKorisnikDomainModel>(Guid Id)
        {
            return await KorisnikGenericReporsitory.GetAsync<IKorisnikDomainModel>(Id);
        }

        public async Task<IEnumerable<IKorisnikDomainModel>> GetAll<IKorisnikDomainModel>()
        {
            return await KorisnikGenericReporsitory.GetAllAsync<IKorisnikDomainModel>();
        }

        public async Task<int> Update<IKorisnikDomainModel>(IKorisnikDomainModel updated)
        {
            return await KorisnikGenericReporsitory.UpdateAsync<IKorisnikDomainModel>(updated);
        }
    }
}
