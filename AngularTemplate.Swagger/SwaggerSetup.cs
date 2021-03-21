using Microsoft.Extensions.DependencyInjection;
using Microsoft.OpenApi.Models;
using Microsoft.AspNetCore.Builder;
using System;
using System.IO;

namespace AngularTemplate.Swagger
{
    public static class SwaggerSetup
    {
        public static IServiceCollection AddSwaggerConfiguration(this IServiceCollection services)
        {
            return services.AddSwaggerGen(opt =>
            {
                opt.SwaggerDoc("v1", new OpenApiInfo
                {
                    Title = "Template .Net Core",
                    Version = "v1",
                    Description = "Desenvolvimento com .Net Core e Angular",
                    Contact = new OpenApiContact
                    {
                        Name = "Rodolfo Queiroz",
                        Email = "rodolfo.dqueiroz@gmail.com"
                    }
                });

                string xmlPath = Path.Combine("wwwroot", "api-doc.xml");
                opt.IncludeXmlComments(xmlPath);
            });
               
        }

        public static IApplicationBuilder UseSwaggerConfiguration(this IApplicationBuilder app)
        {
            return app.UseSwagger().UseSwaggerUI(c =>
            {
                c.RoutePrefix = "documentation";
                c.SwaggerEndpoint("../swagger/v1/swagger.json", "API v1");
            });
        }
    }

    
}
