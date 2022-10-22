using Clean.Architecture.Application.Contract;
using Microsoft.Extensions.DependencyInjection;
using Poc.CleanArchitecture.Domain.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Poc.CleanArchitecture.DependencyInjection
{
    public static class DependencyInjectionDomain
    {
        public static void AddInjectionDomain(this IServiceCollection services) {
            services.AddScoped<ICustomerService, CustomerService>();
        }
    }
}
