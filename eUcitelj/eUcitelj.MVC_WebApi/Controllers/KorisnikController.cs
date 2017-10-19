using AutoMapper;
using eUcitelj.Model.Common;
using eUcitelj.MVC_WebApi.ViewModels;
using eUcitelj.Service;
using eUcitelj.Service.Common;
using Ninject.Activation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;

namespace eUcitelj.MVC_WebApi.Controllers
{
    [RoutePrefix("api/Korisnik")]
    public class KorisnikController : ApiController
    {
        //private KorisnikService KorisnikService = new KorisnikService();
        protected IKorisnikService KorisnikService { get; set; }
        
        public KorisnikController(IKorisnikService korisnikService) 
        {
            this.KorisnikService = korisnikService;
        }
    
        [HttpGet]
        [Route("getallK")]
        public async Task<HttpResponseMessage> GetAllKorisnik()
        {
            try
            {
                var response = Mapper.Map<IEnumerable<KorisnikViewModel>>(await KorisnikService.GetAll<IKorisnikDomainModel>());
                return Request.CreateResponse(HttpStatusCode.OK, response);
            }
            catch (Exception e)
            {
                return Request.CreateErrorResponse(HttpStatusCode.InternalServerError, e);
            }
        }
    }
}
