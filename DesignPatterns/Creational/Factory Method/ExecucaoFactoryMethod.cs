namespace DesignPatterns.Creational.Factory_Method
{
    public class ExecucaoFactoryMethod
    {
        public static void Executar()
        {
            var sqlCn = DbFactory.Database(DataBase.SqlServer)
                                  .CreateConnector("Minha Conexao Sql")
                                  .Connect();

            sqlCn.ExecuteCommand("Executa comando SQL");
            sqlCn.Close();


            var oracleCn = DbFactory.Database(DataBase.Oracle)
           .CreateConnector("Minha Conexao Oracle")
           .Connect();

            oracleCn.ExecuteCommand("Executa comando Oracle");
            oracleCn.Close();


        }
    }
}