using Autofac;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SampleArch.Web.Autofac
{
    public class ServiceModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            //this is why we have to include SampleArch.Service as a reference to the web project.
            //not sure if there is a better way
            builder.RegisterAssemblyTypes(System.Reflection.Assembly.Load("SampleArch.Service"))
                .Where(t => t.Name.EndsWith("Service"))
                .AsImplementedInterfaces()
                .InstancePerLifetimeScope();
        }
    }
}
