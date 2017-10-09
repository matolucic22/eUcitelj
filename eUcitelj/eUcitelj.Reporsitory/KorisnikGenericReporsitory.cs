using AutoMapper;
using eUcitelj.DAL.Models;
using eUcitelj.Model;
using eUcitelj.Reporsitory.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eUcitelj.Reporsitory
{
    public class KorisnikGenericReporsitory : IKorisnikGenericReporsitory
    {
        protected IReporsitory Reporsitory { get; set; }
        KorisnikGenericReporsitory(IReporsitory reporsitory)
        {
            this.Reporsitory = reporsitory;
        }
        public async Task<int> AddAsync<IKorisnikDomainModel>(IKorisnikDomainModel addObj)
        {
            
            return await Reporsitory.AddAsync<Korisnik>(Mapper.Map<Korisnik>(addObj));
        }

        public async Task<int> DeleteAsync<IKorisnikDomainModel>(Guid Id)
        {
            return await Reporsitory.DeleteAsync<Korisnik>(Id);
        }

        public async Task<IEnumerable<IKorisnikDomainModel>> GetAllAsync<IKorisnikDomainModel>()
        {
            try
            {
                return Mapper.Map<IEnumerable<IKorisnikDomainModel>>(await Reporsitory.GetAllAsync<Korisnik>());
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public async Task<IKorisnikDomainModel> GetAsync<IKorisnikDomainModel>(Guid Id)
        {
            try
            {
                return Mapper.Map<IKorisnikDomainModel>(await Reporsitory.GetAsync<Korisnik>(Id));
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public async Task<int> UpdateAsync<IKorisnikDomainModel>(IKorisnikDomainModel updated)
        {
            try
            {
                return await Reporsitory.UpdateAsync<Korisnik>(Mapper.Map<Korisnik>(updated));
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
