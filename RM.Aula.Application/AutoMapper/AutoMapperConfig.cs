using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RM.Aula.Application.AutoMapper
{
    public class AutoMapperConfig
    {
        public static void RegisterMapping()
        {
            Mapper.Initialize(x =>{

                x.AddProfile<DomainToViewModelMappings>();
                x.AddProfile<ToViewModelDomainMappings>();
            });
        }
    }
}
