using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Text;

namespace PS2022.BLL.Registries
{
    public class ConfigurationRegistry
    {
        private static ConfigurationRegistry _instance;

        public IConfiguration Configuration { get; private set; }
        public string ContentRootPath { get; private set; }


        private ConfigurationRegistry(IConfiguration configuration, string contentRootPath)
        {
            Configuration = configuration;
            ContentRootPath = contentRootPath;
        }


        public static ConfigurationRegistry CreateInstance(IConfiguration configuration, string contentRootPath) =>
            _instance = _instance ?? new ConfigurationRegistry(configuration, contentRootPath);

        public static ConfigurationRegistry GetInstance() => _instance;

    }
}
