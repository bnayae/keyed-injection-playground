namespace Bnaya.Samples
{
    public record Keyed<T> (T Target, string Key) : IKeyed<T> where T : class;
}
