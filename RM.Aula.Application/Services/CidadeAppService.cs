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
    public class CidadeAppService : ICidadeAppService
    {
        private readonly ICidadeRepository _cidadeRepository;
        public CidadeAppService()
        {
            _cidadeRepository = new CidadeRepository();
        }
        public IEnumerable<CidadeViewModel> ObteTodos()
        {
            return Mapper.Map<IEnumerable<CidadeViewModel>>(_cidadeRepository.ObterTodos());
        }
    }
}
