namespace DiApi.Data
{
    public class NoSqlDataRepo 
    {
        public string GetData()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("--> Getting data from No SQL Database...");
            Console.ResetColor();
            
            return("SQL Data from DB");
        }
    }
}