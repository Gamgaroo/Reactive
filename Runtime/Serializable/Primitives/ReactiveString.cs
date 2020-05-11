using System;

namespace Gamgaroo.Reactive.Runtime.Serializable.Primitives
{
    [Serializable]
    public sealed class ReactiveString : SerializableReactiveProperty<string>
    {
        public ReactiveString()
        {
        }

        public ReactiveString(string value) : base(value)
        {
        }
    }
}