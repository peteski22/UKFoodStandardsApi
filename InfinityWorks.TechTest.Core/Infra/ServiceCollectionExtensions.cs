namespace InfinityWorks.TechTest.Core.Infra
{
    using MediatR;
    using Microsoft.Extensions.DependencyInjection;

    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection AddCoreHandlers(this IServiceCollection source)
        {
            source.AddMediatR(typeof(ServiceCollectionExtensions).Assembly);
            return source;
        }
    }
}
