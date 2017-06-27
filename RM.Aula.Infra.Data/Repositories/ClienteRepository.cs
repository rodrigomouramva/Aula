using Dapper;
using RM.Aula.Domain.Entities;
using RM.Aula.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RM.Aula.Infra.Data.Repositories
{
    public class ClienteRepository : Repository<Cliente>, IClienteRepository
    {
        public Cliente ObtePorCpf(string cpf)
        {
            return Buscar(c=>c.CPF == cpf).FirstOrDefault();
        }
        public IEnumerable<Cliente> ObterAtivos()
        {
            return Buscar(c => c.Ativo && !c.Excluido);
            //var sql = @"SELECT * FROM Clientes c " +
            //          "WHERE c.Excluido = 0 AND c.Ativo = 1";
            //return Db.Database.Connection.Query<Cliente>(sql);
        }
        public Cliente ObterPorEmail(string email)
        {
            return Buscar(c => c.Email == email).FirstOrDefault();
        }
    }
}
