using AutoMapper;
using RM.Aula.Application.ViewModels;
using RM.Aula.Domain.Entities;

namespace RM.Aula.Application.AutoMapper
{
    public class DomainToViewModelMappings : Profile
    {
        public DomainToViewModelMappings()
        {
            CreateMap<Cliente, ClienteViewModel>();
            CreateMap<Cliente, ClienteEnderecoViewModel>();
            CreateMap<Endereco, EnderecoViewModel>();
            CreateMap<Endereco, ClienteEnderecoViewModel>();
            CreateMap<Pais, PaisViewModel>();

        }
    }
}