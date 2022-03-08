namespace Microsoft.Extensions.DependencyInjection
{
    internal interface IKeyed<T>  where T : class
    {
        T Target { get; }

        string Key { get; }
    }
}
