using Microsoft.AspNetCore.Builder;

namespace Spa.Api
{
    public static class ApplicationBuilderExtensions
    {
        public static IApplicationBuilder UseApi(this IApplicationBuilder applicationBuilder)
        {
            // Enable middleware to serve generated Swagger as a JSON endpoint.
            applicationBuilder.UseSwagger();

            // Enable middleware to serve swagger-ui (HTML, JS, CSS, etc.),
            // specifying the Swagger JSON endpoint.
            applicationBuilder.UseSwaggerUI(c =>
            {
                c.SwaggerEndpoint("/swagger/v1/swagger.json", "My API V1");
                c.RoutePrefix = "ApiDocs";
            });

            return applicationBuilder;
        }
    }
}
