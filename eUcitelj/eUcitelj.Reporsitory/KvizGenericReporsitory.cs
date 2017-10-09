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
    public class KvizGenericReporsitory : IKvizGenericReporsitory
    {
        protected IReporsitory Reporsitory { get; set; }
        KvizGenericReporsitory (IReporsitory reporsitory)
        {
            this.Reporsitory = reporsitory;
        }
        public async Task<int> AddAsync<IKvizDomainModel>(IKvizDomainModel addObj)
        {
            return await Reporsitory.AddAsync<Kviz>(Mapper.Map<Kviz>(addObj));
        }

        public async Task<int> DeleteAsync<IKvizDomainModel>(Guid Id)
        {
            return await Reporsitory.DeleteAsync<Kviz>(Id);
        }

        public async Task<IEnumerable<IKvizDomainModel>> GetAllAsync<IKvizDomainModel>()
        {
            return Mapper.Map<IEnumerable<IKvizDomainModel>>(await Reporsitory.GetAllAsync<Kviz>());
        }

        public async Task<IKvizDomainModel> GetAsync<IKvizDomainModel>(Guid Id)
        {
            return Mapper.Map<IKvizDomainModel>(await Reporsitory.GetAsync<Kviz>(Id));
        }

        public async Task<int> UpdateAsync<IKvizDomainModel>(IKvizDomainModel updated)
        {
            return await Reporsitory.UpdateAsync<Kviz>(Mapper.Map<Kviz>(updated));
        }
    }
}
