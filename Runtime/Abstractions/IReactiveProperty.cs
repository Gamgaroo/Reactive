namespace Gamgaroo.Reactive.Runtime.Abstractions
{
    public interface IReactiveProperty<T> : IReadOnlyReactiveProperty<T>
    {
        new T Value { set; }
    }
}