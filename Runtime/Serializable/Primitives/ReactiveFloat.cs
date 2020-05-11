using System;

namespace Gamgaroo.Reactive.Runtime.Serializable.Primitives
{
    [Serializable]
    public sealed class ReactiveFloat : SerializableReactiveProperty<float>
    {
        public ReactiveFloat()
        {
        }

        public ReactiveFloat(float value) : base(value)
        {
        }
    }
}