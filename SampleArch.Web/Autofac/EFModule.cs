using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Autofac;
using SampleArch.Data.Context;
using SampleArch.Data.UnitOfWork;
using SampleArch.Domain.UnitOfWork;
using System.Data.Entity;

namespace SampleArch.Web.Autofac
{
    public class EFModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterModule(new RepositoryModule());

            builder.RegisterType(typeof(SampleArchContext)).As(typeof(DbContext)).InstancePerLifetimeScope();
            builder.RegisterType(typeof(UnitOfWork)).As(typeof(IUnitOfWork)).InstancePerRequest();            
        }
    }
}