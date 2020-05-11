using System;

namespace Gamgaroo.Reactive.Runtime.Serializable.Primitives
{
    [Serializable]
    public sealed class ReactiveInt : SerializableReactiveProperty<int>
    {
        public ReactiveInt()
        {
        }

        public ReactiveInt(int value) : base(value)
        {
        }
    }
}