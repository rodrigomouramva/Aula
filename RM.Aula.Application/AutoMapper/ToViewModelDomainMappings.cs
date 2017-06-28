using AutoMapper;
using RM.Aula.Application.ViewModels;
using RM.Aula.Domain.Entities;

namespace RM.Aula.Application.AutoMapper
{
    internal class ToViewModelDomainMappings : Profile
    {
        public ToViewModelDomainMappings()
        {
            CreateMap<ClienteViewModel, Cliente>();
            CreateMap<ClienteEnderecoViewModel, Cliente>();
            CreateMap<EnderecoViewModel, Endereco>();
            CreateMap<ClienteEnderecoViewModel, Endereco>();
            CreateMap<PaisViewModel, Pais>();
        }
    }
}