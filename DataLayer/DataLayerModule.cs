using System.Linq;
using Autofac;
using DataLayer.Models;
using DataLayer.Repositories;

namespace DataLayer
{
    public class DataLayerModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<SchoolContext>();
            builder.RegisterTypes(ThisAssembly.GetTypes().Where(t => t.FullName.EndsWith("Repository")).ToArray())
                .AsImplementedInterfaces();
        }
    }
}