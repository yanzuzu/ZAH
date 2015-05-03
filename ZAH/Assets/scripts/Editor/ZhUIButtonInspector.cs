using UnityEngine;
using UnityEditor;

[CanEditMultipleObjects]
[CustomEditor(typeof(ZhUIButton), true)]
public class ZhUIButtonInspector : UIButtonEditor {
	
	protected override void DrawProperties ()
	{
		base.DrawProperties();
		NGUIEditorTools.DrawPaddedProperty ("BtnUIType", serializedObject, "m_btnUIType");
	}
}
