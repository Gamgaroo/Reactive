﻿using Gamgaroo.Reactive.Runtime.Serializable.Primitives;
using UnityEditor;

namespace Gamgaroo.Reactive.Editor.Primitives
{
    [CustomPropertyDrawer(typeof(ReactiveFloat))]
    public sealed class ReactiveFloatPropertyDrawer : SerializableReactivePropertyDrawer
    {
    }
}