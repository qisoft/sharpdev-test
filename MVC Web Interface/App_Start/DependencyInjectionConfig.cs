using System.Linq;
using System.Reflection;
using Autofac;
using DataLayer;
using DataLayer.Models;
using DataLayer.Repositories;
using Autofac.Integration.Mvc;
using MVC_Web_Interface.Models.Builders;

namespace MVC_Web_Interface
{
    public class DependencyInjectionConfig
    {
        public static IContainer Configure()
        {
            var builder = new ContainerBuilder();
            builder.RegisterModule<DataLayerModule>();
            builder.RegisterControllers(Assembly.GetExecutingAssembly());
            RegisterModelBuilders(builder);
            return builder.Build();
        }

        private static void RegisterModelBuilders(ContainerBuilder builder)
        {
            builder.RegisterTypes(
                Assembly.GetExecutingAssembly().GetTypes().Where(t => t.FullName.EndsWith("ModelBuilder")).ToArray())
                .AsImplementedInterfaces();
        }
    }
}