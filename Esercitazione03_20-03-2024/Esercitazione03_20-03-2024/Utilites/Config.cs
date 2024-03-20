using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Esercitazione03_20_03_2024.Utilites
{
    internal class Config
    {
        private static Config? istanza;
        private string? connectionString;

        private Config() { }

        public static Config getIstanza()
        {
            if(istanza == null)
            {
                istanza = new Config();
            }
            return istanza;
        }

        public string? GetConnectionString()
        {
            if(connectionString == null)
            {
                ConfigurationBuilder builder = new ConfigurationBuilder();
                builder.SetBasePath(Directory.GetCurrentDirectory());
                builder.AddJsonFile("appSettings.json", optional: false, reloadOnChange: false);

                IConfiguration configuration = builder.Build();
#if DEBUG
                connectionString = configuration.GetConnectionString("ServerLocale");
#else
                connectionString = configuration.GetConnectionString("ServerRemota");
#endif
            }
            return connectionString;
        }




    }
}
