using RM.Aula.Application.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RM.Aula.Application.ViewModels;
using RM.Aula.Domain.Interfaces;
using RM.Aula.Infra.Data.Repositories;
using AutoMapper;
using RM.Aula.Domain.Entities;

namespace RM.Aula.Application.Services
{
    public class ClienteAppService : IClienteAppService
    {
        private readonly IClienteRepository _clienteRepository;
        public ClienteAppService()
        {
            _clienteRepository = new ClienteRepository();
        }
        public ClienteEnderecoViewModel Adicionar(ClienteEnderecoViewModel clienteEnderecoViewModel)
        {
            var cliente = Mapper.Map<Cliente>(clienteEnderecoViewModel.Cliente);
            //var endereco = Mapper.Map<Endereco>(clienteEnderecoViewModel.Endereco);
            //cliente.Enderecos.Add(endereco);
            cliente.Ativo = true;
            _clienteRepository.Adicionar(cliente);
            return clienteEnderecoViewModel;            
        }
        public ClienteViewModel Atualizar(ClienteViewModel clienteViewModel)
        {
            var cliente = Mapper.Map<Cliente>(clienteViewModel);
            _clienteRepository.Atualizar(cliente);
            return clienteViewModel;
        }
        public void Dispose()
        {
            _clienteRepository.Dispose();
        }
        public IEnumerable<ClienteViewModel> ObterAtivos()
        {
            return Mapper.Map<IEnumerable<ClienteViewModel>>(_clienteRepository.ObterTodos());
        }
        public ClienteViewModel ObterPorCpf(string cpf)
        {
            return Mapper.Map<ClienteViewModel>(_clienteRepository.ObtePorCpf(cpf));
        }
        public ClienteViewModel ObterPorEmail(string email)
        {
            return Mapper.Map<ClienteViewModel>(_clienteRepository.ObterPorEmail(email));
        }
        public ClienteViewModel ObterPorId(Guid id)
        {
            return Mapper.Map<ClienteViewModel>(_clienteRepository.ObterPorId(id));
        }
        public IEnumerable<ClienteViewModel> ObteTodos()
        {
            return Mapper.Map<IEnumerable<ClienteViewModel>>(_clienteRepository.ObterTodos());
        }
        public void Remover(Guid id)
        {
            _clienteRepository.Remover(id);
        }
    }
}
