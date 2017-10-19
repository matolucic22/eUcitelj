using AutoMapper;
using eUcitelj.Model;
using eUcitelj.Model.Common;
using eUcitelj.MVC_WebApi.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace eUcitelj.MVC_WebApi.AutoMapperConfig
{
    public class MappingProfile:Profile
    {
#pragma warning disable CS0672 // Member 'MappingProfile.Configure()' overrides obsolete member 'Profile.Configure()'. Add the Obsolete attribute to 'MappingProfile.Configure()'.
        protected override void Configure()
#pragma warning restore CS0672 // Member 'MappingProfile.Configure()' overrides obsolete member 'Profile.Configure()'. Add the Obsolete attribute to 'MappingProfile.Configure()'.
        {
            //Domain to View
            CreateMap<KorisnikDomainModel, KorisnikViewModel>().ReverseMap();
            //Interface(Domain)-Domain
            CreateMap<KorisnikDomainModel, IKorisnikDomainModel>().ReverseMap();
            //Interface(Domain)-View
            CreateMap<IKorisnikDomainModel, KorisnikViewModel>().ReverseMap();


            //Domain to View
            CreateMap<PredmetiDomainModel, PredmetiViewModel>().ReverseMap();
            //Interface(Domain)-Domain
            CreateMap<PredmetiDomainModel, IPredmetiDomainModel>().ReverseMap();
            //Interface(Domain)-View
            CreateMap<IPredmetiDomainModel, PredmetiViewModel>().ReverseMap();


            //Domain to View
            CreateMap<OcjeneDomainModel, OcjeneViewModel>().ReverseMap();
            //Interface(Domain)-Domain
            CreateMap<OcjeneDomainModel, IOcjeneDomainModel>().ReverseMap();
            //Interface(Domain)-View
            CreateMap<IOcjeneDomainModel, OcjeneViewModel>().ReverseMap();


            //Domain to View
            CreateMap<KvizDomainModel, KvizViewModel>().ReverseMap();
            //Interface(Domain)-Domain
            CreateMap<KvizDomainModel, IKvizDomainModel>().ReverseMap();
            //Interface(Domain)-View
            CreateMap<IKvizDomainModel, KvizViewModel>().ReverseMap();
        }
    }
}