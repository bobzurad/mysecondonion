using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Autofac;
using SampleArch.Data.Context;
using SampleArch.Data.UnitOfWork;
using SampleArch.Domain.UnitOfWork;

namespace SampleArch.Web.Autofac
{
    public class EFModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterModule(new RepositoryModule());

            //builder.RegisterType(typeof(SampleArchContext)).AsSelf().InstancePerLifetimeScope();
            builder.RegisterType(typeof(ISampleArchContext)).AsImplementedInterfaces().InstancePerLifetimeScope();
            builder.RegisterType(typeof(IUnitOfWork)).AsImplementedInterfaces().InstancePerRequest();
            //builder.RegisterType(typeof(UnitOfWork)).As(typeof(IUnitOfWork)).InstancePerRequest();
        }
    }
}