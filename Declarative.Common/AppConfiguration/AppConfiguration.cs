﻿//using System.IO;
//using Microsoft.Extensions.Configuration;

//namespace Declarative.Common.AppConfiguration
//{
//    public class AppConfiguration
//    {
//        public AppConfiguration()
//        {
//            var configBuilder = new ConfigurationBuilder();
//            var path = Path.Combine(Directory.GetCurrentDirectory(), "appsettings.json");
//            configBuilder.AddJsonFile(path, false);
//            var root = configBuilder.Build();
//            var connection = root.GetSection("ConnetionString:DefaultConnection");
//            sqlConnectionString = connection.Value;
//        }
//        public string sqlConnectionString { get; set; }
//    }
//}
