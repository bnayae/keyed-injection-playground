namespace Bnaya.Samples
{
    public interface IKeyed<T>  where T : class
    {
        T Target { get; }

        string Key { get; }
    }
}
