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
    public class PaisAppService : IPaisAppService
    {
        private readonly IPaisRepository _paisRepository;
        public PaisAppService()
        {
            _paisRepository = new PaisRepository();
        }
        public IEnumerable<PaisViewModel> ObteTodos()
        {
            return Mapper.Map<IEnumerable<PaisViewModel>>(_paisRepository.ObterTodos());
        }
    }
}
