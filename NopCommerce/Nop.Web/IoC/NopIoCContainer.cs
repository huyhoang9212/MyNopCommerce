using Autofac;
using Autofac.Integration.Mvc;
using Nop.Core.Data;
using Nop.Data;
using Nop.Services.Blogs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace Nop.Web.IoC
{
    public class NopIoCContainer
    {
        public static void RegisterDependencies()
        {
            var builder = new ContainerBuilder();

            // controllers
            builder.RegisterControllers(typeof(MvcApplication).Assembly);

            // dependencies
            builder.RegisterType<NopObjectContext>().As<IDbContext>().InstancePerLifetimeScope();
            builder.RegisterGeneric(typeof(EfRepository<>)).As(typeof(IRepository<>)).InstancePerLifetimeScope();
            builder.RegisterType<BlogService>().As<IBlogService>().InstancePerLifetimeScope();

            // set dependency resolver
            var container = builder.Build();
            DependencyResolver.SetResolver(new AutofacDependencyResolver(container));
        }
    }
}
