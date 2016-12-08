﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.Configuration;

namespace SmartAdmin
{
    public class Program
    {
        public static void Main(string[] args)
        {
          //var config = new ConfigurationBuilder()
          //      .SetBasePath(Directory.GetCurrentDirectory())
          //      .AddJsonFile("hosting.json", optional: true)
          //      .Build();

          //var config = new ConfigurationBuilder()
          //    .AddCommandLine(args)
          //    .Build();

            var host = new WebHostBuilder()
                .UseKestrel()
                .UseContentRoot(Directory.GetCurrentDirectory())
                .UseIISIntegration()
                .UseStartup<Startup>()
                .Build();

            host.Run();
        }
    }
}
