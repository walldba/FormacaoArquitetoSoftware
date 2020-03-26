namespace DesignPatterns.Creational.Factory_Method
{
    //Concrete Product
    public class OracleDbConnector : DbConnector
    {
        public OracleDbConnector(string connectionString) : base(connectionString)
            => ConnectionString = connectionString;

            public override Connection Connect()
            {
                //Conexao com banco Oracle
                var connection = new Connection(ConnectionString);
                connection.Open();

                return connection;
            }
    }
}