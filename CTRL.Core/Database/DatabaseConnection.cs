using CTRL.Core.Interfaces;

namespace CTRL.Core.Database
{
    public class DatabaseConnection : IDatabaseConnection
    {
        public string ConnectionString { get; }

        public DatabaseConnection(string connectionString)
        {
            ConnectionString = connectionString;
        }
    }
}
