namespace DiApi.DataServices
{
    public class HttpDataService : IDataService
    {
        public string GetProductData(string url)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("--> Getting data from HttpDataService...");
            Console.ResetColor();

            return("Http Data from HttpDataService");
        }
    }
}