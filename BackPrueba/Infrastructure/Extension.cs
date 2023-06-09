﻿using BackPrueba.Infrastructure.Data;
using BackPrueba.Infrastructure.Managers;
using BackPrueba.Infrastructure.Managers.Interfaces;
using BackPrueba.Infrastructure.Repositories;
using BackPrueba.Infrastructure.Repositories.Interfaces;
using BackPrueba.Infrastructure.Services;
using BackPrueba.Infrastructure.Services.Interfaces;
using Microsoft.Extensions.Logging;

namespace BackPrueba.Infrastructure
{
    public static class Extension
    {
        public static void AddInfrastructure(this IServiceCollection services, IConfiguration configuration)
        {
            // Data
            services.AddSingleton<DataJourney>();

            //Services
            services.AddSingleton<IJourneyService, JourneyService>();

            // Repositories
            services.AddScoped<IJourneyRepository, JourneyRepository>();

            //Managers 
            services.AddScoped<IJourneyManager, JourneyManager>();

            services.AddCors(options =>
            {
                options.AddPolicy(name: "Cors",
                                  policy =>
                                  {
                                      policy.WithHeaders("content - type");
                                      policy.AllowAnyHeader();
                                      policy.AllowAnyOrigin();
                                      policy.AllowAnyMethod();
                                  });
            });

        }
    }
}
