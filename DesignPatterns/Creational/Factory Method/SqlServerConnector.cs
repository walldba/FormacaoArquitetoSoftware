namespace DesignPatterns.Creational.Factory_Method
{
    //Concrete Product
    public class SqlServerConnector : DbConnector
    {
        public SqlServerConnector(string connectionString) : base(connectionString)
            => ConnectionString = connectionString;

            public override Connection Connect()
            {
                //Conexao com banco SQL SERVER
                var connection = new Connection(ConnectionString);
                connection.Open();

                return connection;
            }
    }
}