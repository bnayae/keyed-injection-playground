namespace Microsoft.Extensions.DependencyInjection
{
    public interface IKeyedSelector<T>  where T : class
    {
        T this [string key] { get;  }
    }


}
