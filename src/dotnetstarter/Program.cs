using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;

namespace SmartAdmin
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var host = new WebHostBuilder()
                .UseKestrel()
                .UseContentRoot(Directory.GetCurrentDirectory())
                .UseIISIntegration()
                .UseStartup<Startup>()
                .UseUrls("http://aspnetcoressoperu.mybluemix.net", "https://aspnetcoressoperu.mybluemix.net:443", "https://*:443", "http://*:80")
                .Build();

            host.Run();
        }
    }
}
