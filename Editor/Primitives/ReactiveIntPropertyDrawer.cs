using Gamgaroo.Reactive.Runtime.Serializable.Primitives;
using UnityEditor;

namespace Assets.Gamgaroo.Reactive.Editor.Primitives
{
    [CustomPropertyDrawer(typeof(ReactiveInt))]
    public sealed class ReactiveIntPropertyDrawer : SerializableReactivePropertyDrawer
    {
    }
}