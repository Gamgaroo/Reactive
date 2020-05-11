using Gamgaroo.Reactive.Runtime.Serializable.Primitives;
using UnityEditor;

namespace Assets.Gamgaroo.Reactive.Editor.Primitives
{
    [CustomPropertyDrawer(typeof(ReactiveString))]
    public sealed class ReactiveStringPropertyDrawer : SerializableReactivePropertyDrawer
    {
    }
}