using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace eShopSolution.Data.EF
{
    public class EShopDbContextFactory : IDesignTimeDbContextFactory<EShopDbContext>
    {
        public EShopDbContext CreateDbContext(string[] args)
        {
            IConfigurationRoot configuration = new ConfigurationBuilder()
                    .SetBasePath(Directory.GetCurrentDirectory())
                    .AddJsonFile("appsettings.json")
                    .Build();

            var connectionStrings = configuration.GetConnectionString("eShopSolutionDb");

            var optionsBuider = new DbContextOptionsBuilder<EShopDbContext>();
            optionsBuider.UseSqlServer(connectionStrings);
            return new EShopDbContext(optionsBuider.Options);
        }
    }
}
