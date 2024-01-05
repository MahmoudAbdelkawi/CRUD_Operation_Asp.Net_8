namespace CRUD_Operation
{
    public class DBConnectionSingleton
    {
        private static DBConnectionSingleton _instance;
        public static DBConnectionSingleton Instanse
        {
            get
            {
                lock (_lock)
                {
                    if (_instance is null)
                        _instance = new DBConnectionSingleton();
                    return _instance;
                }
            }
        }
        private static object _lock = new();
        private string _connectionString;
        private DBConnectionSingleton()
        {
            var configuration = new ConfigurationBuilder()
                .AddJsonFile("appsettings.json")
                .Build();
            _connectionString = configuration.GetConnectionString("DefaultConnection");
        }

        public static DBConnectionSingleton Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new DBConnectionSingleton();
                }
                return _instance;
            }
        }

        public string ConnectionString
        {
            get { return _connectionString; }
            set { _connectionString = value; }
        }
    }
}
