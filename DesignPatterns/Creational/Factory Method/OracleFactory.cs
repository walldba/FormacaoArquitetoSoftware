namespace DesignPatterns.Creational.Factory_Method
{
    //Concrete Creator
    public class OracleFactory : DbFactory
    {
        //Factory Method
        public override DbConnector CreateConnector(string connectionString)
        => new SqlServerConnector(connectionString);
    }
}