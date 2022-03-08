namespace Bnaya.Samples
{
    public static class Extensions
    {
        public static IServiceCollection AddKeyedSingleton<TService,  TImplementation>(
            this IServiceCollection services, string key) 
            where TService : class where TImplementation : class, TService
        {
            services.AddSingleton<TService, TImplementation>();
            services.AddSingleton<IKeyed<TService>>(sp => 
            {
                var items = sp.GetServices<TService>().Where(m => m is TImplementation);
                var imp = items.First();
                var keyed = new Keyed<TService>(imp, key);

                return keyed;
            });
            services.AddSingleton<IKeyedSelector<TService>>(sp => 
            {
                return new KeyedSelector<TService>(sp);
            });


            return services;
        }


    }
}
