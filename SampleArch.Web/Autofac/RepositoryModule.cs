using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Autofac;

namespace SampleArch.Web.Autofac
{
    public class RepositoryModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            //this is why we have to include SampleArch.Data as a reference to the web project.
            //not sure if there is a better way
            builder.RegisterAssemblyTypes(System.Reflection.Assembly.Load("SampleArch.Data"))
                .Where(t => t.Name.EndsWith("Repository"))
                .AsImplementedInterfaces()
                .InstancePerLifetimeScope();
        }
    }
}
