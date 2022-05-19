﻿using MediatR;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace MovieRecommApp.Business
{
    public static class Startup
    {
        public static IServiceCollection AddApplication(this IServiceCollection services)
        {
            var assembly = Assembly.GetExecutingAssembly();
            return services                
                .AddMediatR(assembly);
        }
    }
}
