using eUcitelj.DAL;
using eUcitelj.DAL.Common;
using eUcitelj.DAL.Models;
using eUcitelj.Model;
using eUcitelj.Model.Common;
using eUcitelj.Reporsitory;
using eUcitelj.Reporsitory.Common;
using eUcitelj.Service;
using eUcitelj.Service.Common;
using Ninject.Modules;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eUcitelj.DeResolver.NinjectConfig
{
    class Resolver:NinjectModule
    {
        public override void Load()
        {
            Bind<IeUciteljContext>().To<eUciteljContext>();
            Bind<IKorisnik>().To<Korisnik>();
            Bind<IPredmeti>().To<Predmeti>();
            Bind<IOcjene>().To<Ocjene>();
            Bind<IKviz>().To<Kviz>();

            Bind<IKorisnikDomainModel>().To<KorisnikDomainModel>();
            Bind<IPredmetiDomainModel>().To<PredmetiDomainModel>();
            Bind<IOcjeneDomainModel>().To<OcjeneDomainModel>();
            Bind<IKvizDomainModel>().To<KvizDomainModel>();

            Bind<IKorisnikGenericReporsitory>().To<KorisnikGenericReporsitory>();
            Bind<IPredmetiGenericReporsitory>().To<PredmetiGenericReporsitory>();
            Bind<IOcjeneGenericReporsitory>().To<OcjeneGenericReporsitory>();
            Bind<IKvizGenericReporsitory>().To<KvizGenericReporsitory>();

            Bind<IKorisnikService>().To<KorisnikService>();
            Bind<IPredmetiService>().To<PredmetiService>();
            Bind<IOcjeneService>().To<OcjeneService>();
            Bind<IKvizService>().To<KvizService>();
        }
    }
}
