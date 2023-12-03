namespace APICredito.API.Configuration
{
    public static class DependencyInjection
    {
        public static IServiceCollection ConfigureInjections(this IServiceCollection services) 
        {
            services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());

            return services;
        }
    }
}
