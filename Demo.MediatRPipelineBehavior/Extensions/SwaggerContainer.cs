
namespace Demo.MediatRPipelineBehavior.Extensions
{
    using Microsoft.Extensions.DependencyInjection;
    using Microsoft.OpenApi.Models;
    using System;

    internal static class SwaggerContainer
    {
        private const string REPOSITORIO = "https://github.com/AndrewMak/DemoMediatrPipelineBehavior";

        public static IServiceCollection AddSwagger(this IServiceCollection services)
        {
            services.AddSwaggerGen(options =>
            {
                options.SwaggerDoc("v1", new OpenApiInfo
                {
                    Title = "Demo MediatR with PipelineBehavior",
                    Version = "v1",
                    Description = "API para demonstrar o uso do pipelinebehavior com fluentvalidator",
                    Contact = new OpenApiContact
                    {
                        Url = new Uri(REPOSITORIO),
                        Name = "Andrew Chan Mak",
                        Email = "andrew.cm.sp@gmail.com"
                    }
                });
            });

            return services;
        }
    }
}
