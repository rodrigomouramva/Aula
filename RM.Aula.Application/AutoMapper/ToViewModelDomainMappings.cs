using System;
using AutoMapper;
using RM.Aula.Application.ViewModels;
using RM.Aula.Domain.Entities;

namespace RM.Aula.Application.AutoMapper
{
    public class ToViewModelDomainMappings : Profile
    {
        
        protected override void Configure()
        {
            CreateMap<ClienteViewModel, Cliente>();
            CreateMap<ClienteEnderecoViewModel, Cliente>();
            CreateMap<EnderecoViewModel, Endereco>();
            CreateMap<ClienteEnderecoViewModel, Endereco>();
            CreateMap<PaisViewModel, Pais>();
            CreateMap<EstadoViewModel, Estado>();
            CreateMap<CidadesViewModel, Cidade>();
        }
    }
}