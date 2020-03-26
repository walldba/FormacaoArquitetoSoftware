namespace DesignPatterns.Creational.Factory_Method
{
    public class Connection
    {
        public string ConnectionString { get; set; }
        public bool Opened { get; set; }
        public Connection(string connectionString)
            => ConnectionString = connectionString;

        public void ExecuteCommand(string command)
        {
            //Executar comando SQL
        }

        public void Open()
        => Opened = true;

        public void Close()
        => Opened = false;
    }
}