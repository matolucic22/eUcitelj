using AutoMapper;
using eUcitelj.DAL.Models;
using eUcitelj.Reporsitory.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eUcitelj.Reporsitory
{
    public class PredmetiGenericReporsitory : IPredmetiGenericReporsitory
    {
        protected IReporsitory Reporsitory{ get; set;}
        PredmetiGenericReporsitory(IReporsitory reporsitory)
        {
            this.Reporsitory = reporsitory;
        }

        public async Task<int> AddAsync<IPredmetiDomainModel>(IPredmetiDomainModel addObj)
        {
            return await Reporsitory.AddAsync<Korisnik>(Mapper.Map<Korisnik>(addObj));
        }

        public async Task<int> DeleteAsync<IPredmetiDomainModel>(Guid Id)
        {
            return await Reporsitory.DeleteAsync<Korisnik>(Id);
        }

        public async Task<IEnumerable<IPredmetiDomainModel>> GetAllAsync<IPredmetiDomainModel>()
        {
            return Mapper.Map<IEnumerable<IPredmetiDomainModel>>(await Reporsitory.GetAllAsync<Predmeti>());
        }

        public async Task<IPredmetiDomainModel> GetAsync<IPredmetiDomainModel>(Guid Id)
        {
            return Mapper.Map<IPredmetiDomainModel>(await Reporsitory.GetAsync<Predmeti>(Id));
        }

        public async Task<int> UpdateAsync<IPredmetiDomainModel>(IPredmetiDomainModel updated)
        {
            return await Reporsitory.UpdateAsync<Predmeti>(Mapper.Map<Predmeti>(updated));
        }
    }
}
