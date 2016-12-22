﻿using Framework.Core.Service;
using Microsoft.Extensions.DependencyInjection;
using Sample.DotNetFramework.Common.DTO;
using Sample.DotNetFramework.ServicesLayer.Interfaces;
using Sample.DotNetFramework.ServicesLayer.Services;

namespace Sample.DotNetFramework.MVC6.Configuration
{
    /// <summary>
    /// Classe de configuration des services de l'application
    /// </summary>
    internal static class ConfigureAppServices
    {
        /// <summary>
        /// Méthode d'ajout des services de l'application
        /// </summary>
        /// <param name="services">Collection des services en provenance du startup</param>
        internal static void Configure(ref IServiceCollection services)
        {
            // A utiliser pour le framework generic
            //services.AddScoped<GenericService<UserModel>, GenericService<UserModel>>();
            //services.AddScoped<GenericService<SampleModel>, GenericService<SampleModel>>();

            // A utiliser lorsqu'on gère soit même les services (en dehors du framework generic)
            //services.AddScoped<IUserService, UserService>();
        }
    }
}
