namespace Microsoft.Extensions.DependencyInjection
{
    public record Keyed<T> (T Target, string Key) : IKeyed<T> where T : class;
}
