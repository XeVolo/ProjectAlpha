using Auth.Interfaces;
using Auth.Services;
using Auth.Token;
using Microsoft.Extensions.DependencyInjection;
using Repositories;
using Repositories.Base;
using Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Auth.Extensions;
public static class ServiceCollectionExtensions
{
    public static IServiceCollection AddAuth(this IServiceCollection services)
    {
        services.AddScoped<IAuthService, AuthService>();
        services.AddScoped<ITokenService, TokenService>();

        return services;
    }
}
