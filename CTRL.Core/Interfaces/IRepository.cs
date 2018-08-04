using Dapper;
using System.Collections.Generic;

namespace CTRL.Core.Interfaces
{
    public interface IRepository
    {
        IEnumerable<T> ExecuteStoredProcedureQuery<T>(string sproc, DynamicParameters parameters);
    }
}
