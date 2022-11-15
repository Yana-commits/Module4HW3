using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Options;
using Module4HW3;

internal class Program
{
    private static void Main(string[] args)
    {
        var bulder = new ConfigurationBuilder();
        bulder.SetBasePath(Directory.GetCurrentDirectory());
        bulder.AddJsonFile("appsetting.json");
        var config = bulder.Build();
        var connectionString = config.GetConnectionString("DefaultConnection");

        var optionBuilder = new DbContextOptionsBuilder<ApplicationContext>();
        var options = optionBuilder
            .UseSqlServer(connectionString)
            .Options;

        using (var db = new ApplicationContext(options))
        { 
        }

        Console.Read();
    }
}