using BuberDinner.Api.Common.Mapping;

namespace BuberDinner.Api;

public static class DependencyInjection
{
    public static IServiceCollection AddPresentation(this IServiceCollection services)
    {
        // builder.Services.AddControllers(options => options.Filters.Add<ErrorHandlingFilterAttribute>());
        services.AddControllers();
        services.AddEndpointsApiExplorer();
        services.AddSwaggerGen();
        services.AddMappings();
        return services;
    }
}