using Autofac;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;

namespace DAL.IoC
{
    public static class Bootstraper
    {
        public static void Bootstrap(ContainerBuilder container)
        {
            container.RegisterAssemblyTypes(Assembly.GetExecutingAssembly())
                .Where(x => x.Name.EndsWith("Repository") && !x.IsAbstract)
                .AsImplementedInterfaces()
                .WithParameter(
                    (paramInfo, _) => paramInfo.Name == "connectionString",
                    (_, contex) => contex.Resolve<IConfiguration>().GetConnectionString("DefaultConnection")
                );
        }
    }
}
