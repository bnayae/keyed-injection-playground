namespace Microsoft.Extensions.DependencyInjection
{
    internal record Keyed<T> (T Target, string Key) : IKeyed<T> where T : class;
}
