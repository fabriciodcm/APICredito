using APICredito.Application.Factory;
using APICredito.Application.Interface.Factory;
using APICredito.Application.Interface.Services;
using APICredito.Application.Services;

namespace APICredito.API.Configuration
{
    public static class DependencyInjection
    {
        public static IServiceCollection ConfigureInjections(this IServiceCollection services) 
        {
            services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());
            #region Services
            services.AddScoped<ICalcularCreditoService, CalcularCreditoService>();
            #endregion
            #region Factory
            services.AddScoped<ITipoCreditoFactory,TipoCreditoFactory>();
            #endregion
            
            return services;
        }
    }
}
