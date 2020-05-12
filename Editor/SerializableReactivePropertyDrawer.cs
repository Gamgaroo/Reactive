using UnityEditor;
using UnityEngine;

namespace Gamgaroo.Reactive.Editor
{
    public abstract class SerializableReactivePropertyDrawer : PropertyDrawer
    {
        public override void OnGUI(Rect position, SerializedProperty property, GUIContent label)
        {
            EditorGUI.PropertyField(position, property.FindPropertyRelative("_value"), label);
        }
    }
}