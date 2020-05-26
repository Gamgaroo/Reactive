using System;

namespace Gamgaroo.Reactive.Runtime.Abstractions
{
    public interface IReadOnlyReactiveProperty<out T>
    {
        T Value { get; }

        event Action<T> OnValueChanged;
    }
}