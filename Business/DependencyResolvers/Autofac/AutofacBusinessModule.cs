using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Autofac;
using Business.Abstract;
using Business.Concrete;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework;

namespace Business.DependencyResolvers.Autofac
{
    public class AutofacBusinessModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<DbOrderManager>().As<IDbOrderService>().SingleInstance();
            builder.RegisterType<EfDbOrderDAL>().As<IDbOrderDAL>().SingleInstance();
        }
    }
}