using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Hosting;

namespace CustomTagHelpers
{
    public class Program
    {
        public static void Main(string[] args)
        {
            CreateWebHostBuilder(args).Build().Run();
        }

        public static IHostBuilder CreateWebHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder()
                .ConfigureWebHostDefaults(builder => builder.UseStartup<Startup>());
    }
}