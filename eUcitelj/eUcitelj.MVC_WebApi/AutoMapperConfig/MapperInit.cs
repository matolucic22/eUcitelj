using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace eUcitelj.MVC_WebApi.AutoMapperConfig
{
    public class MapperInit
    {
        public static void Init()
        {
            Mapper.Initialize(cfg => cfg.AddProfiles(new[] {
                typeof(eUcitelj.MVC_WebApi.AutoMapperConfig.MappingProfile),
                typeof(eUcitelj.DeResolver.MappingConfig.MappingProfile)
               })
           );
        }
    }
}