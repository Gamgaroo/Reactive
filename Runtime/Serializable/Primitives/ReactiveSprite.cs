using System;
using UnityEngine;

namespace Gamgaroo.Reactive.Runtime.Serializable.Primitives
{
    [Serializable]
    public sealed class ReactiveSprite : SerializableReactiveProperty<Sprite>
    {
        public ReactiveSprite()
        {
        }

        public ReactiveSprite(Sprite value) : base(value)
        {
        }
    }
}