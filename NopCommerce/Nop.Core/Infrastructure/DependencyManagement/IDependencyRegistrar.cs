using Autofac;

namespace Nop.Core.Infrastructure.DependencyManagement
{
    public interface IDependencyRegistrar
    {
        void Register(ContainerBuilder builder);
    }
}
