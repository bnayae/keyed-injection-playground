namespace Bnaya.Samples
{
    public class KeyedSelector<T>: IKeyedSelector<T> where T : class
    {
        private readonly IServiceProvider _serviceProvider;

        public KeyedSelector(IServiceProvider serviceProvider)
        {
            _serviceProvider = serviceProvider;
        }

        T IKeyedSelector<T>.this[string key] => 
                            _serviceProvider.GetServices<IKeyed<T>>()
                                .Where(m => m.Key == key)
                                .First()
                                .Target;
    }
}
