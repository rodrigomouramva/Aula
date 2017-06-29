using System;
using AutoMapper;
using RM.Aula.Application.ViewModels;
using RM.Aula.Domain.Entities;

namespace RM.Aula.Application.AutoMapper
{
    public class DomainToViewModelMappings : Profile
    {
        
        protected override void Configure()
        {
            CreateMap<Cliente, ClienteViewModel>();

            CreateMap<Cliente, ClienteEnderecoViewModel>();
            CreateMap<Endereco, EnderecoViewModel>();
            CreateMap<Endereco, ClienteEnderecoViewModel>();
            
        }
    }
}