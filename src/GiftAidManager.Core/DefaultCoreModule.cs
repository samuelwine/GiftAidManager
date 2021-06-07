using Autofac;
using GiftAidManager.Core.Interfaces;
using GiftAidManager.Core.Services;

namespace GiftAidManager.Core
{
    public class DefaultCoreModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<ToDoItemSearchService>()
                .As<IToDoItemSearchService>().InstancePerLifetimeScope();
        }
    }
}
