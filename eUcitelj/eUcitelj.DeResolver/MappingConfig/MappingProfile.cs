using AutoMapper;
using eUcitelj.DAL.Common;
using eUcitelj.DAL.Models;
using eUcitelj.Model;
using eUcitelj.Model.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eUcitelj.DeResolver.MappingConfig
{
   public class MappingProfile:Profile
    {
#pragma warning disable CS0672 // Member 'MappingProfile.Configure()' overrides obsolete member 'Profile.Configure()'. Add the Obsolete attribute to 'MappingProfile.Configure()'.
        protected override void Configure()
#pragma warning restore CS0672 // Member 'MappingProfile.Configure()' overrides obsolete member 'Profile.Configure()'. Add the Obsolete attribute to 'MappingProfile.Configure()'.
        {
            ////AspNetUser database <-> AspNetUser domain
            //CreateMap<AspNetUser, IAspNetUserDomain>().PreserveReferences().ReverseMap().PreserveReferences();
            //CreateMap<AspNetUser, AspNetUserDomain>().PreserveReferences().ReverseMap().PreserveReferences();

            //POCO to Domain
            CreateMap<Korisnik, KorisnikDomainModel>().ReverseMap();
            //POCO to IDomain
            CreateMap<Korisnik, IKorisnikDomainModel>().ReverseMap();
            //POCO to IPOCO
            CreateMap<Korisnik, IKorisnik>().ReverseMap();


            //POCO to Domain
            CreateMap<Predmeti, PredmetiDomainModel>().ReverseMap();
            //POCO to IDomain
            CreateMap<Predmeti, IPredmetiDomainModel>().ReverseMap();
            //POCO to IPOCO
            CreateMap<Predmeti, IPredmeti>().ReverseMap();


            //POCO to Domain
            CreateMap<Ocjene, OcjeneDomainModel>().ReverseMap();
            //POCO to IDomain
            CreateMap<Ocjene, IOcjeneDomainModel>().ReverseMap();
            //POCO to IPOCO
            CreateMap<Ocjene, IOcjene>().ReverseMap();


            //POCO to Domain
            CreateMap<Kviz, KvizDomainModel>().ReverseMap();
            //POCO to IDomain
            CreateMap<Kviz, IKvizDomainModel>().ReverseMap();
            //POCO to IPOCO
            CreateMap<Kviz, IKviz>().ReverseMap();
        }

    }
}
