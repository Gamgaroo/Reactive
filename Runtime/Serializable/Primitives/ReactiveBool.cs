using System;

namespace Gamgaroo.Reactive.Runtime.Serializable.Primitives
{
    [Serializable]
    public sealed class ReactiveBool : SerializableReactiveProperty<bool>
    {
        public ReactiveBool()
        {
        }

        public ReactiveBool(bool value) : base(value)
        {
        }
    }
}