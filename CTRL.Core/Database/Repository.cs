using System.Collections.Generic;
using CTRL.Core.Interfaces;
using Dapper;

namespace CTRL.Core.Database
{
    public class Repository : IRepository
    {
        private IDatabaseConnection _connection;

        public Repository(IDatabaseConnection connection)
        {
            _connection = connection;
        }

        public IEnumerable<T> ExecuteStoredProcedureQuery<T>(string sproc, DynamicParameters parameters)
        {
            throw new System.NotImplementedException();
        }
    }
}
