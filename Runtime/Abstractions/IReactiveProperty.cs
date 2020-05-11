using System;

namespace Gamgaroo.Reactive.Runtime.Abstractions
{
    public interface IReactiveProperty<T>
    {
        T Value { get; set; }

        event Action<T> OnValueChanged;
    }
}