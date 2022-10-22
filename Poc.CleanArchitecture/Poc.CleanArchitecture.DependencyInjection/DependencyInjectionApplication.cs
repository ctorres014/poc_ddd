using Clean.Architecture.Application.Service;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Poc.CleanArchitecture.DependencyInjection
{
    public static class DependencyInjectionApplication
    {
        public static void AddInjectionApplication(this IServiceCollection services)
        {
            services.AddScoped<ICustomerServiceApplication, CustomerServiceApplication>();
        }
    }
}
