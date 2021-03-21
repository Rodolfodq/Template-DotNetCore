using AngularTemplate.Application.Interfaces;
using AngularTemplate.Application.Services;
using AngularTemplate.Data.Repositories;
using AngularTemplate.Domain.Interfaces;
using Microsoft.Extensions.DependencyInjection;
using System;

namespace AngularTemplate.IOC
{
    public static class NativeInjector
    {
        public static void RegisterServices(IServiceCollection services)
        {
            #region Services

            services.AddScoped<IUserService, UserService>();

            #endregion

            #region Repositories

            services.AddScoped<IUserRepository, UserRepository>();

            #endregion

        }
    }
}
