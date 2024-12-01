using Microsoft.Extensions.DependencyInjection;
using Netmusiclib.interfaces;
using Netmusiclib.services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Netmusiclib
{
    public static class NetMusiclibExtension
    {
        public static IServiceCollection AddNetMusiclib(this IServiceCollection serviceDescriptors)
        {
            serviceDescriptors.AddScoped<ISearcher, Searcher>();
            return serviceDescriptors;
        }
    }
}
