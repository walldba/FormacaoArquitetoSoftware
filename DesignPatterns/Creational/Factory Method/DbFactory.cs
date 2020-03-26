using System;

namespace DesignPatterns.Creational.Factory_Method
{
    public abstract class DbFactory
    {
        public abstract DbConnector CreateConnector(string connectionString);

        public static DbFactory Database(DataBase dataBase)
        {
            if (dataBase == DataBase.SqlServer)
                return new SqlFactory();
            if (dataBase == DataBase.Oracle)
                return new OracleFactory();

            throw new ApplicationException("Database não registrada");

        }
    }
}