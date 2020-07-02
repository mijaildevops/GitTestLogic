// Branch Master
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;

namespace webMartes
{
    // Nuevos cambios para GIthub (Clone)
    // subir Cambios a Github
    // update tres para github
    public class Program // este es un comentario para Sprint2
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Saludos de Edgar");
            CreateHostBuilder(args).Build().Run();
        }

        // cambio desde master
        // cambio en Branch Sprint2
        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();
                });
    }
}
