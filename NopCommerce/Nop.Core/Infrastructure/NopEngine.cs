using Autofac;


namespace Nop.Core.Infrastructure
{
    public class NopEngine
    {
        public void Initialize()
        {
            RegisterDependencies();
        }

        protected virtual void RegisterDependencies()
        {
            var builder = new ContainerBuilder();
            var container = builder.Build();


        }
    }
}
