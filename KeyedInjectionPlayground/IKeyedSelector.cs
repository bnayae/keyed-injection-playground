namespace Bnaya.Samples
{
    public interface IKeyedSelector<T>  where T : class
    {
        T this [string key] { get;  }
    }


}
