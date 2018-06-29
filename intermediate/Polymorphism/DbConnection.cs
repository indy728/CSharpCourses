using System;

namespace Polymorphism
{
    public abstract class DbConnection
    {
        public string ConnectionString { get; set; }
        public TimeSpan Timeout { get; set; }

        public abstract void OpenConnection();
        public abstract void CloseConnection();
    }

    public class DbCommand
    {
        private DbConnection _connection;
        private string _instruction;
        public DbCommand(DbConnection dbConnection, string instruction)
        {
            if (dbConnection == null)
                throw new InvalidOperationException("No Db connection was passed for DbCommand.");
            _connection = dbConnection;
            _instruction = instruction;
        }

        public void Execute()
        {
            _connection.OpenConnection();
            Console.WriteLine(_instruction);
            _connection.CloseConnection();
        }
    }

    public class SqlConnection : DbConnection
    {
        public SqlConnection(string connectionString)
        {
            if (String.IsNullOrEmpty(connectionString))
                throw new InvalidOperationException("Cannot form a db connection without a connection string.");
            ConnectionString = connectionString;
        }
        
        public override void OpenConnection()
        {
            Console.WriteLine("Created a connection with SQL database. with connection string " + this.ConnectionString);
        }
        public override void CloseConnection()
        {
            Console.WriteLine("Closed a connection with SQL database.");
        }
    }
    public class OracleConnection : DbConnection
    {
        public OracleConnection(string connectionString)
        {
            if (String.IsNullOrEmpty(connectionString))
                throw new InvalidOperationException("Cannot form a db connection without a connection string.");
            ConnectionString = connectionString;
        }

        public override void OpenConnection()
        {
            Console.WriteLine("Created a connection with Oracle database. with connection string " + this.ConnectionString);
        }
        public override void CloseConnection()
        {
            Console.WriteLine("Closed a connection with Oracle database.");
        }
    }
}