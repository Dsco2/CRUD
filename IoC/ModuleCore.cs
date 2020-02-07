using Autofac;
using Business.Interfaces;
using Business.Services;
using Persistence.Repository;

namespace IoC
{
    public class ModuleCore : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<ManagementService>().As<IManagementService>();
            builder.RegisterType<ManagementRepository>().As<IManagementRepository>();
        }
    }
}
