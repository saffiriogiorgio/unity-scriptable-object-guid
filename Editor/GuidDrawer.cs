using UnityEditor;
using UnityEngine;
using UnityExtendedScriptable;

namespace UnityExtendedScriptable.Editor
{
    [CustomPropertyDrawer(typeof(UnityExtendedScriptable.Guid))]
    public class GuidDrawer : PropertyDrawer
    {
        public override void OnGUI(Rect position, SerializedProperty property, GUIContent label)
        {
            EditorGUI.BeginProperty(position, label, property);
            position = EditorGUI.PrefixLabel(position, GUIUtility.GetControlID(FocusType.Passive), new GUIContent ("Guid", label.image, label.tooltip));
           
            SerializedProperty serializedGuid = property.FindPropertyRelative("m_guidSerialized");
            EditorGUI.SelectableLabel(position, $"{serializedGuid.stringValue}", EditorStyles.textField);

            EditorGUI.EndProperty();
        }
    }

}