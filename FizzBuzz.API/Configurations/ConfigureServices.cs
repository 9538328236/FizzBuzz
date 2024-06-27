using FizzBuzz.API.Interfaces;
using FizzBuzz.API.Services;

namespace CodingTestAPI.Configurations
{
    public static class ConfigureServices
    {

        public static IServiceCollection AddWebServices(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddScoped<ICodingTestService, CodingCourseService>();
            return services;
        }
    }
}
    