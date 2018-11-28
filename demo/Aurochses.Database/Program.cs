using System;
using Aurochses.Database.EntityFrameworkCore;
using Microsoft.AspNetCore.Hosting;

namespace Aurochses.Database
{
    public class Program : ProgramBase
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }

        public static IWebHostBuilder CreateWebHostBuilder(string[] args) =>
            CreateWebHostBuilder<Startup>(args);
    }
}