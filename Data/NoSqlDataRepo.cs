using DiApi.DataServices;

namespace DiApi.Data
{
    public class NoSqlDataRepo : IDataRepo
    {
        // private readonly IDataService _dataService;
        private readonly IServiceScopeFactory _scopeFactory;

        public NoSqlDataRepo(IServiceScopeFactory scopeFactory)
        {
            _scopeFactory = scopeFactory;
        }                    

        public string ReturnData()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("--> Getting data from No SQL Database...");

            using var scope = _scopeFactory.CreateScope();
            var dataService = scope.ServiceProvider.GetRequiredService<IDataService>();
            dataService.GetProductData("http://www.something.com/api");
            
            Console.ResetColor();
            
            return("SQL Data from DB");
        }
    }
}