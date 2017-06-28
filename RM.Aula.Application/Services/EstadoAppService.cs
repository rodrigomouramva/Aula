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

namespace RM.Aula.Application.Services
{
    public class EstadoAppService : IEstadoAppService
    {
        private readonly IEstadoRepository _estadoRepository;
        public EstadoAppService()
        {
            _estadoRepository = new EstadoRepository();
        }
        public IEnumerable<EstadoViewModel> ObteTodos()
        {
            return Mapper.Map<IEnumerable<EstadoViewModel>>(_estadoRepository.ObterTodos());
        }
    }
}
