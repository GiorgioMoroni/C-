using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DB_Lez05_Correzione_Esercitazione03.Utilities
{
    internal class Config
    {
        private static Config? instance;
        private string? connectionString;

        private Config() { }

        public static Config getInstance()
        {
            if (instance == null)
            {
                instance = new Config();
            }
            return instance;
        }

        public string? getConnectionString()
        {
            if(connectionString == null)
            {
                ConfigurationBuilder builder = new();

                builder.SetBasePath(Directory.GetCurrentDirectory());
                builder.AddJsonFile("appSettings.json", optional: false, reloadOnChange: false);

                IConfiguration configuration = builder.Build();

                connectionString = configuration.GetConnectionString("ServerLocale");

            }
            return connectionString;
        }




    }
}
