using UnityEngine;
#if UNITY_EDITOR
using UnityEditor;
#endif
public class LabeledBool : PropertyAttribute
{
    public string labelWhenTrue;
    public string labelWhenFalse;
    public LabeledBool(string labelWhenTrue, string labelWhenFalse)
    {
        this.labelWhenTrue = labelWhenTrue;
        this.labelWhenFalse = labelWhenFalse;
    }

#if UNITY_EDITOR
    [CustomPropertyDrawer(typeof(LabeledBool))]
    public class ThisPropertyDrawer : PropertyDrawer
    {
        public override void OnGUI(Rect position, SerializedProperty property, GUIContent label)
        {
            LabeledBool propertyAttribute = this.attribute as LabeledBool;
            label.text = property.boolValue ? propertyAttribute.labelWhenTrue : propertyAttribute.labelWhenFalse;
            EditorGUI.PropertyField(position, property, label);
        }
    }
#endif
}